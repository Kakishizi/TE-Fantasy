// using Cysharp.Threading.Tasks;
// using Fantasy;
// using Fantasy.Async;
// using Fantasy.Network;
// using TEngine;
// using Log = TEngine.Log;
//
// namespace GameLogic
// {
//     public static class AuthHelper
//     {
//         public static async FTask<uint> Register(string account, string password)
//         {
//             GameModule.Client.Connect();
//             await UniTask.Delay(2000);
//             C2A_RegisterRequest request = new C2A_RegisterRequest();
//             request.Account = account;
//             request.Password = password;
//             var response = (A2C_RegisterResponse)await GameModule.Client.Call(request);
//             //GameModule.Client.Disconnect();
//             return response.ErrorCode;
//         }
//
//         public static async FTask<uint> Login(string account, string password)
//         {
//             GameModule.Client.Connect();
//             // C2A_LoginRequest request = C2A_LoginRequest.Create();
//             C2A_LoginRequest request = new C2A_LoginRequest();
//             request.Account = account;
//             request.Password = password;
//             var response = (A2C_LoginResponse)await GameModule.Client.Call(request);
//             //断开鉴权服务器的连接
//             GameModule.Client.Disconnect();
//             if (response.ErrorCode == ErrorCode.Success)
//             {
//                 //连接到Gate服务器
//                 GameModule.Client.Connect(response.Address, NetworkProtocolType.KCP,
//                     onConnectFail: () => { Log.Error("连接Gate服务器失败"); },
//                     onConnectDisconnect: () => { Log.Info("Gate服务器断开连接"); }, isHttps: false, connectTimeout: 5000);
//                 // C2G_LoginRequest c2GLoginRequest = C2G_LoginRequest.Create();
//                 C2G_LoginRequest c2GLoginRequest = new C2G_LoginRequest();
//                 c2GLoginRequest.Token = response.Token;
//                 var c2GLoginResponse = (G2C_LoginResponse)await GameModule.Client.Call(c2GLoginRequest);
//                 return c2GLoginResponse.ErrorCode;
//             }
//
//             return response.ErrorCode;
//         }
//     }
// }