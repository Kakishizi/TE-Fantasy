using System;
using TEngine;

namespace GameLogic
{
    public static class TipsHelper
    {
        public static void ShowTip(string desc, int showtype = 0, int style = 0,
            Action onOk = null,
            Action onCancel = null,
            Action onPackage = null)
        {
            GameEvent.Send(ActorEventDefine.OpenTip, desc, showtype, style, onOk, onCancel, onPackage);
        }
    }
}