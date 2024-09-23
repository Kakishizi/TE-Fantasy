using TMPro;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using TEngine;

namespace GameLogic
{
    [Window(UILayer.UI)]
    class UILoginWindow : UIWindow
    {
        #region 脚本工具生成的代码
        private TMP_InputField  m_TmpInputAccount;
        private TMP_InputField  m_TmpInputPsw;
        private Button m_btnLogin;
        protected override void ScriptGenerator()
        {
            m_TmpInputAccount = FindChildComponent<TMP_InputField >("m_TmpInputAccount");
            m_TmpInputPsw = FindChildComponent<TMP_InputField >("m_TmpInputPsw");
            m_btnLogin = FindChildComponent<Button>("m_btnLogin");
            m_btnLogin.onClick.AddListener(UniTask.UnityAction(OnClickLoginBtn));
        }
        #endregion

        #region 事件
        private async UniTaskVoid OnClickLoginBtn()
        {
            await UniTask.Yield();
        }
        #endregion

    }
}