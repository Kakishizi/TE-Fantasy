using TMPro;
using Cysharp.Threading.Tasks;
using Fantasy;
using Fantasy.Network;
using UnityEngine;
using UnityEngine.UI;
using TEngine;

namespace GameLogic
{
    [Window(UILayer.UI)]
    class UILoginWindow : UIWindow
    {
        #region 脚本工具生成的代码

        private TMP_InputField m_TmpInputAccount;
        private TMP_InputField m_TmpInputPsw;
        private Button m_btnLogin;
        private Button m_btnRegister;

        protected override void ScriptGenerator()
        {
            m_TmpInputAccount = FindChildComponent<TMP_InputField>("m_TmpInputAccount");
            m_TmpInputPsw = FindChildComponent<TMP_InputField>("m_TmpInputPsw");
            m_btnLogin = FindChildComponent<Button>("m_btnLogin");
            m_btnRegister = FindChildComponent<Button>("m_btnRegister");
            m_btnLogin.onClick.AddListener(OnClickLoginBtn);
            m_btnRegister.onClick.AddListener(OnClickRegisterBtn);
        }

        #endregion

        #region 事件

        private async void OnClickLoginBtn()
        {
            var error = await AuthHelper.Login(m_TmpInputAccount.text, m_TmpInputPsw.text);
            if (error != ErrorCode.Success)
            {
                TipsHelper.ShowTip($"登录失败[{error}]");
                return;
            }

            GameModule.UI.ShowUI<ULobbyWindow>();
        }

        private async void OnClickRegisterBtn()
        {
            var error = await AuthHelper.Register(m_TmpInputAccount.text, m_TmpInputPsw.text);
            if (error != ErrorCode.Success)
            {
                TipsHelper.ShowTip($"注册失败[{error}]");
                return;
            }
        }

        #endregion

        private void OnConnectFail()
        {
            Debug.Log("连接失败");
        }

        private void OnConnectDisconnect()
        {
            Debug.Log("连接断开");
        }
    }
}