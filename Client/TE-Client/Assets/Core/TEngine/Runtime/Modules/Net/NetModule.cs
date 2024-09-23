using System;
using TEngine;

namespace TEngine
{
    public class NetModule : Module
    {
        private INetModule _netModule ;

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
    }
}