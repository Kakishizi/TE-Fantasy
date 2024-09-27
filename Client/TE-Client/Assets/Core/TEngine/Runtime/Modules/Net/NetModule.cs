using System;
using System.Reflection;
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
        [SerializeField] private string _remoteAddress = "127.0.0.1";
        private int WebPort = 20001;
        private int Port = 20000;

        private async void Start()
        {
            if (_netModule is null)
            {
                _netModule = ModuleImpSystem.GetModule<NetModuleImp>();
            }

            Log.Debug("NetModule Start");
        }

        public async void Init(Assembly[] assemblies)
        {
            Fantasy.Platform.Unity.Entry.Initialize(assemblies);
            _netModule.Scene = await Fantasy.Platform.Unity.Entry.CreateScene();
        }

        public void ConnectToRealm()
        {
#if FANTASY_WEBGL
            _netModule.Connect($"{_remoteAddress}:{WebPort}", NetworkProtocolType.KCP, () => { Log.Info("连接成功"); },
                () => { Log.Error("连接失败"); }, (() => { Log.Info("连接断开"); }), false);
#else
            _netModule.Connect($"{_remoteAddress}:{Port}", NetworkProtocolType.KCP, () => { Log.Info("连接成功"); },
                () => { Log.Error("连接失败"); }, (() => { Log.Info("连接断开"); }), false);
#endif
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