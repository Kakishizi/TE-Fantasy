using Fantasy;
using Fantasy.Async;
using Fantasy.Entitas;
using Fantasy.Entitas.Interface;
using Fantasy.Helper;
using Model;

#pragma warning disable CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。

#pragma warning disable CS8602 // 解引用可能出现空引用。

namespace Hotfix;

public class AuthenticationAccountComponentSystem_Awake: AwakeSystem<AuthenticationAccountComponent>
{
    protected override void Awake(AuthenticationAccountComponent self)
    {
        self.AccountLock=self.Scene.CoroutineLockComponent.Create(self.GetType().TypeHandle.Value.ToInt64());
    }
}public class AuthenticationAccountComponentSystem_Destroy: DestroySystem<AuthenticationAccountComponent>
{
    protected override void Destroy(AuthenticationAccountComponent self)
    {
        self.AccountLock = null;
    }
}

public static class AuthenticationAccountComponentSystem
{

    public static async FTask<(uint errorCode, Account? account)> GetAccount(this AuthenticationAccountComponent self,
        string userName,
        string password)
    {
        if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
        {
            //传递参数不正确
            return (ErrorCode.Error_LoginFail, null);
        }

        var userNameHash = userName.GetHashCode();
        var database = self.Scene.World.DateBase;
        using (await self.AccountLock.Wait(userNameHash,"AccountLock"))
        {
            if (!self.Cache.TryGetValue(userNameHash, out Account account))
            {
                account = await database.First<Account>(d => d.UserName == userName);
                if (account == null)
                {
                    // 用户不存在
                    Log.Info($"{userName} 用户不存在");
                    return (ErrorCode.Error_LoginFail, null);
                }

                self.Cache.Add(userNameHash, account);
            }

            // 验证密码
            if (!BCrypt.Net.BCrypt.Verify(password, account.Password))
            {
                //验证失败 密码错误
                Log.Info($"{userName} 密码错误");
                return (ErrorCode.Error_LoginFail, null);
            }

            account.LogicTime = TimeHelper.Now;
            // 保存到数据库中
            await database.Save(account);
            return (ErrorCode.Success, account);
        }
    }

    public static async FTask<uint> Register(this AuthenticationAccountComponent self, string userName, string password)
    {
        if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
        {
            //传递参数不正确
            return ErrorCode.Error_Empty;
        }

        var userNameHash = userName.GetHashCode();

        using (await self.AccountLock.Wait(userNameHash))
        {
            if (self.Cache.ContainsKey(userNameHash))
            {
                // 用户已注册过
                return  ErrorCode.Error_AccountExist;
            }

            var worldDataBase = self.Scene.World.DateBase;
            bool isExist = await worldDataBase.Exist<Account>(d => d.UserName == userName);
            if (isExist)
            {
                // 当前用户已经注册过 数据库存在
                return ErrorCode.Error_AccountExist;
            }

            Account account = Entity.Create<Account>(self.Scene,false,true);
            account.UserName = userName;
            account.Password = BCrypt.Net.BCrypt.HashPassword(password);
            account.CreatTime = TimeHelper.Now;
            // 添加入缓存中
            self.Cache.Add(userNameHash, account);
            //保存到数据库
            await worldDataBase.Save(account);
        }

        return 0;
    }
}