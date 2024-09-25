using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using Fantasy;
using Fantasy.Entitas.Interface;
using Microsoft.IdentityModel.Tokens;
using Model;

namespace Hotfix;

public sealed class JwtComponentAwakeSystem : AwakeSystem<JwtComponent>
{
    protected override void Awake(JwtComponent self)
    {
        self.Awake();
    }
}public sealed class JwtComponentDestroySystem : DestroySystem<JwtComponent>
{
    protected override void Destroy(JwtComponent self)
    {
        self.signingCredentials = null;
        self.tokenValidationParameters = null;
    }
}

public static class JwtComponentSystem
{
    public static void Awake(this JwtComponent self)
    {
        RSA rsa = RSA.Create(); //创建RSA
        //导入公钥和私钥
        var publicKey = GetKey(self.PubicKeyPem, "-----BEGIN RSA PUBLIC KEY-----", "-----END RSA PUBLIC KEY-----");
        var privateKey = GetKey(self.PrivateKeyPem, "-----BEGIN RSA PRIVATE KEY-----", "-----END RSA PRIVATE KEY-----");
        rsa.ImportRSAPublicKey(publicKey, out _);
        rsa.ImportRSAPrivateKey(privateKey, out _);
        //创建签名证书
        self.signingCredentials = new SigningCredentials(new RsaSecurityKey(rsa), SecurityAlgorithms.RsaSha256);
        // 创建TokenValidationParameters 对象，用于配置验证参数
        self.tokenValidationParameters = new TokenValidationParameters()
        {
            ValidateLifetime = false, // 禁止令牌验证时间是否过期
            ValidateIssuer = true, // 验证发行者
            ValidateAudience = true, // 验证接收者
            ValidateIssuerSigningKey = true, // 验证签名密钥
            ValidIssuer = "Ange", // 发行者
            ValidAudience = "Ange", // 接收者
            IssuerSigningKey = new RsaSecurityKey(rsa) // RSA公钥作为签名密钥
        };
    }

    /// <summary>
    /// 创建一个新的Token
    /// </summary>
    /// <param name="accountId"></param>
    /// <param name="sceneId"></param>
    /// <param name="timeOut"></param>
    /// <returns></returns>
    public static string CreateToken(this JwtComponent self, long accountId, long sceneId, int timeOut = 30000)
    {
        JwtPayload payLoad = new JwtPayload()
        {
            { "aId", accountId },
            { "sId", sceneId },
        };
        JwtSecurityToken jwt = new JwtSecurityToken(
            issuer: "Ange",
            audience: "Ange",
            claims: payLoad.Claims,
            expires: DateTime.Now.AddMilliseconds(timeOut),
            signingCredentials: self.signingCredentials);
        return new JwtSecurityTokenHandler().WriteToken(jwt);
    }

    /// <summary>
    /// 验证令牌
    /// </summary>
    /// <param name="self"></param>
    /// <param name="token"></param>
    /// <param name="payload"></param>
    /// <returns></returns>
    public static bool ValidationToken(this JwtComponent self, string token, out JwtPayload? payload)
    {
        payload = null;
        try
        {
            JwtSecurityTokenHandler jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            jwtSecurityTokenHandler.ValidateToken(token, self.tokenValidationParameters, out _);
            payload = jwtSecurityTokenHandler.ReadJwtToken(token).Payload;
            return true;
        }
        catch (SecurityTokenExpiredException)
        {
            Log.Error("Token已过期");
            return false;
        }
        catch (SecurityTokenValidationException ex)
        {
            Log.Error(ex);
            return false;
        }
        catch (Exception e)
        {
            Log.Error(e);
            return false;
        }
    }

    private static byte[] GetKey(string str, string start, string end)
    {
        var key = str.Replace(start, "").
            Replace(end, "").
            Replace("\n", "").
            Replace("\r", "");
        return Convert.FromBase64String(key);
    }
}