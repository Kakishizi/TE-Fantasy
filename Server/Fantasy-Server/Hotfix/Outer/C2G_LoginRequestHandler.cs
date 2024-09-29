using Fantasy.Async;
using Fantasy.Network;
using Fantasy.Network.Interface;
using Hotfix;
using Model;

namespace Fantasy;

public class C2G_LoginRequestHandler : MessageRPC<C2G_LoginRequest,G2C_LoginResponse>
{
    protected async override FTask Run(Session session, C2G_LoginRequest request, G2C_LoginResponse response, Action reply)
    {
        // 这里是处理登录的逻辑
        // 你可以在这里做登录验证，或者其他的逻辑
        // 这里我直接返回一个成功的消息
          Log.Debug("登录请求");
        if (string.IsNullOrEmpty(request.Token))
        {
            //如果Token为空，代表恶意连接，直接断开连接
            session.Dispose();
            return;
        }

        // 验证Token
        var scene = session.Scene;
        JwtComponent jwtComponent = scene.GetComponent<JwtComponent>();
        if (!jwtComponent.ValidationToken(request.Token, out var payload) ||
            Convert.ToInt64(payload["sId"]) != scene.SceneConfigId)
        {
            //如果令牌验证失败，代表恶意连接，直接断开连接
            session.Dispose();
            return;
        }

         var accountId = Convert.ToInt64(payload["aId"]); //通过令牌拿到账号ID
        // var roleComponent = scene.GetComponent<RoleComponent>();
        // OnlineSessionComponent onlineSessionComponent = scene.GetComponent<OnlineSessionComponent>();
        // if (!roleComponent.TryGet(accountId, out var role))
        // {
        //     //在数据库中查找这个Role
        //     role = await RoleHelper.LoadRoleFromDataBase(scene, accountId);
        //     if (role == null)
        //     {
        //         role = RoleFactory.CreateRole(scene, accountId, request.userName);
        //         await role.SaveRoleFromDataBase();
        //         Log.Debug("创建一个新的Role");
        //     }
        //
        //     role.SessionRunTimeId = session.RunTimeId; //保存当前Session的RuntimeId，用于后面判定使用
        //     onlineSessionComponent.Add(session);
        //     roleComponent.Add(role);
        // }
        // else
        // {
        //     //取消延迟下线任务
        //     role.RemoveComponent<ScheduledTaskComponent>();
        //     //账号已经登陆过，情况如下
        //     // 1、客户端发送了重复的登录数据
        //     // 2、客户端断线重连
        //     // 3、客户端同时登陆了同一个账号
        //     if (role.SessionRunTimeId == session.RunTimeId)
        //     {
        //         //客户端发送了重复的登录数据，这样的情况客户端已经建立好连接了所以不需要继续处理
        //         response.ErrorCode = ErrorCode.Error_LoginFail;
        //         return;
        //     }
        //     // 逻辑到这里只有断线重连和顶号的情况
        //     if (onlineSessionComponent.TryGet(role.SessionRunTimeId, out Session oldSession))
        //     {
        //         // 设置为0，为了不让这个Session销毁的时候下线这个Role
        //         oldSession.GetComponent<RoleFlagComponent>().accountId = 0;
        //         // 发送顶号通知给客户端
        //         oldSession.Send(new H_G2C_RepeatLogin());
        //         //客户端断线重连，这样的情况客户端已经建立好连接了所以不需要继续处理
        //         oldSession.SetTimeOut(3000);
        //         onlineSessionComponent.Remove(oldSession);
        //     }
        //     role.SessionRunTimeId = session.RunTimeId;
        //     Log.Debug("用户重复登陆了 但是角色在缓存中获取到");
        // }
        // // 给Session挂载一个组件，当这个Session断线的时候，这个组件会自动释放进行下线操作
        // session.AddComponent<RoleFlagComponent>().accountId = accountId;
        // response.RoleInfo = role.GetRoleInfo();
        Log.Debug($"用户[{accountId}]登陆成功，连接客户端Session[{session.RunTimeId}]");
    }
}