using UnityEditor;

namespace TEngine.Editor
{
    public class WXGameDefineSymbols
    {
    
        
        private const string MacroName = "UNITY_WECHAT_GAME";

        [MenuItem("TEngine/EnableWxGame", priority=32)]
        public static void ToggleWeChatGameMacro()
        {
            var currentDefines = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.WebGL);
            if (currentDefines.Contains(MacroName))
            {
                currentDefines = currentDefines.Replace(MacroName + ";", "").Replace(MacroName, "");
                EditorUtility.DisplayDialog("WeChat Game Macro", "宏命令已关闭", "OK");
            }
            else
            {
                currentDefines += ";" + MacroName;
                EditorUtility.DisplayDialog("WeChat Game Macro", "宏命令已开启", "OK");
            }
            PlayerSettings.SetScriptingDefineSymbolsForGroup(BuildTargetGroup.WebGL, currentDefines);
        }

        [MenuItem("TEngine/EnableWxGame", true)]
        public static bool ValidateToggleWeChatGameMacro()
        {
            var currentDefines = PlayerSettings.GetScriptingDefineSymbolsForGroup(BuildTargetGroup.WebGL);
            Menu.SetChecked("TEngine/EnableWxGame", currentDefines.Contains(MacroName));
            return true;
        }
    }
}