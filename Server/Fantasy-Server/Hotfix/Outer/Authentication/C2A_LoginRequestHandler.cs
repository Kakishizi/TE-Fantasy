// using Fantasy.Async;
// using Fantasy.Network;
// using Fantasy.Network.Interface;
// using Fantasy.Platform.Net;
// using Hotfix;
// using Model;
//
// namespace Fantasy;
//
// public class C2A_LoginRequestHandler : MessageRPC<C2A_LoginRequest, A2C_LoginResponse>
// {
//     protected override async FTask Run(Session session, C2A_LoginRequest request, A2C_LoginResponse response,
//         Action reply)
//     {
//         try
//         {
//             if (session.RunTimeId == 0)
//             {
//                 response.ErrorCode = ErrorCode.Error_SessionInvaild;
//                 return;
//             }
//
//             Scene scene = session.Scene;
//             AuthenticationAccountComponent acc = scene.GetComponent<AuthenticationAccountComponent>();
//             JwtComponent jwtComponent = scene.GetComponent<JwtComponent>();
//             var result = await acc.GetAccount(request.Account, request.Password);
//             if (result.account == null)
//             {
//                 response.ErrorCode = result.errorCode;
//                 return;
//             }
//
//             response.ErrorCode = result.errorCode;
//             //分配一个Gate服务器
//             var gateScenes = SceneConfigData.Instance.GetSceneBySceneType(SceneType.Gate);
//             var gateSceneIndex = (int)result.account.Id % gateScenes.Count;
//             var gateSceneInfo = gateScenes[gateSceneIndex];
//             //创建一个新的令牌
//             response.Token = jwtComponent.CreateToken(result.account.Id, gateSceneInfo.Id);
//             if (acc.CacheOuterAddress.TryGetValue(gateSceneInfo.Id, out string? address))
//             {
//                 response.Address = address;
//                 return;
//             }
//             ProcessConfig processConfig = ProcessConfigData.Instance.Get(gateSceneInfo.ProcessConfigId);
//             MachineConfig machineConfig = MachineConfigData.Instance.Get(processConfig.MachineId);
//             address = $"{machineConfig.OuterIP}:{gateSceneInfo.OuterPort}";
//             acc.CacheOuterAddress.Add(gateSceneInfo.Id, address);
//             response.Address = address;
//         }
//         finally
//         {
//             Log.Debug($"登陆到鉴权服务器Session[{session.RunTimeId}]");
//             session.SetTimeOut(2000);
//         }
//     }
// }