using System;
using Fantasy.Async;
using Fantasy.Network;
using Fantasy.Network.Interface;
using TEngine;
using UnityEngine;

namespace TEngine
{
    public class NetModule : Module
    {
        private INetModule _netModule;
        [SerializeField] private string _remoteAddress = "127.0.0.1:20000";

        private async void Start()
        {
            if (_netModule is null)
            {
                _netModule = ModuleImpSystem.GetModule<NetModuleImp>();
            }
            
            Fantasy.Platform.Unity.Entry.Initialize();
            _netModule.Scene = await Fantasy.Platform.Unity.Entry.CreateScene();
            Log.Info("NetModule Start");
        }

        public void Connect()
        {
            _netModule.Connect(_remoteAddress, NetworkProtocolType.KCP, () => { Log.Info("连接成功"); },
                () => { Log.Error("连接失败"); }, (() => {Log.Info("连接断开");}), false);
        }

        public void Connect(string remoteAddress, NetworkProtocolType networkProtocolType, Action onConnectFail,
            Action onConnectDisconnect, bool isHttps,
            int connectTimeout = 5000)
        {
            _netModule.Connect(remoteAddress, networkProtocolType, onConnectFail, onConnectDisconnect, isHttps,
                connectTimeout);
        }


        public void Send(IMessage message)
        {
            _netModule.Send(message);
        }

        public async FTask<IResponse> Call(IRequest request)
        {
            return await _netModule.Call(request);
        }

        public void Disconnect()
        {
            _netModule.Release();
        }
    }
}