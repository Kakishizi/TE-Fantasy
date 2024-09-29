using Fantasy.Async;
using Fantasy.Network;
using Fantasy.Network.Interface;
using Hotfix;
using Model;

namespace Fantasy;

public class C2A_RegisterRequestHandler: MessageRPC<C2A_RegisterRequest,A2C_RegisterResponse>
{
    protected override async FTask Run(Session session, C2A_RegisterRequest request, A2C_RegisterResponse response, Action reply)
    {

        try
        {
            AuthenticationAccountComponent authenticationAccountComponent = session.Scene.GetComponent<AuthenticationAccountComponent>();
            response.ErrorCode = await authenticationAccountComponent.Register(request.Account, request.Password);
        }
        finally
        {
            // 设置超时时间
            session.SetTimeOut(2000);
        }
    }
}