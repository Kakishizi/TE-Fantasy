using System;
using GameMain;
using TEngine;

namespace GameLogic
{
    public static class TipsHelper
    {
        public static void ShowTip(string desc)
        {
            UILoadTip.ShowMessageBox(desc,onOk:(() =>
            {
                GameModule.UI.CloseUI<UILoadTip>();
            }));
        }
    }
}