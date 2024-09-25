using System;
using Fantasy;
using Fantasy.Async;
using Fantasy.Network;
using Fantasy.Network.Interface;
using TEngine;

namespace TEngine
{
    internal class NetModuleImp : ModuleImp, INetModule
    {
        public Scene Scene { get; set; }

        internal override void Shutdown()
        {
            Scene.Dispose();
        }


        public void Connect(string remoteAddress, NetworkProtocolType networkProtocolType, Action onConnectFail,
            Action onConnectDisconnect, bool isHttps, int connectTimeout = 5000)
        {
            Scene.Connect(remoteAddress, networkProtocolType, OnConnectComplete, onConnectFail, onConnectDisconnect,
                isHttps, connectTimeout);
        }

        public void Connect(string remoteAddress, NetworkProtocolType networkProtocolType,
            Action onConnectSuccess,
            Action onConnectFail, Action onConnectDisconnect, bool isHttps, int connectTimeout = 5000)
        {
            Scene.Connect(remoteAddress, networkProtocolType, onConnectSuccess, onConnectFail, onConnectDisconnect,
                isHttps, connectTimeout);
        }

        private void OnConnectComplete()
        {
            Log.Debug("连接成功");
            Scene.Session.AddComponent<SessionHeartbeatComponent>().Start(2000);
        }

        public async FTask<IResponse> Call(IRequest request)
        {
            if (Scene.Session is null)
            {
                Log.Error("未连接到服务器");
                return null;
            }

            return await Scene.Session.Call(request);
        }

        public void Send(IMessage message)
        {
            if (Scene.Session is null)
            {
                Log.Error("未连接到服务器");
                return;
            }

            Scene.Session.Send(message);
        }

        public void Release()
        {
            Scene.Session.Dispose();
        }
    }
}