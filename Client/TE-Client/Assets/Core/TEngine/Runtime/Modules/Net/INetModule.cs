using System;
using Fantasy;
using Fantasy.Async;
using Fantasy.Network;
using Fantasy.Network.Interface;

namespace TEngine
{
    public interface INetModule
    {
        /// <summary>
        /// 网络所属Scene
        /// </summary>
        public Scene Scene { get; set; }

        public void Connect(string remoteAddress, NetworkProtocolType networkProtocolType, Action onConnectFail,
            Action onConnectDisconnect, bool isHttps, int connectTimeout = 5000);

        public void Connect(string remoteAddress, NetworkProtocolType networkProtocolType,
            Action onConnectSuccess, Action onConnectFail, Action onConnectDisconnect, bool isHttps,
            int connectTimeout = 5000);

        public FTask<IResponse> Call(IRequest request);

        public void Send(IMessage message);
        
        public void Release();
    }
}