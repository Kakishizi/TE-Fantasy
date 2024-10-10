using AVG_Command_Creator;
using System;
using System.Collections;
using System.Collections.Generic;
using AVG_Command;
using GameBase;
using TEngine;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

namespace AVG_module
{
    public class AVGModule : Singleton<AVGModule>
    {
        // ���ⲿ���ý������
        public UnityEvent plotBegin = new UnityEvent();

        // ÿ�ξ�����������䶯��������Զ���������ⲿ���Զ���ע��һЩ�ص�
        public UnityEvent plotEnd = new UnityEvent();

        // ��ǰ�Ѿ�չʾ�Ľ�ɫ�ֵ�
        public Dictionary<string, AvgPortraitCom> characters = new Dictionary<string, AvgPortraitCom>();

        // ��ʼ�������￪ʼ
        public void Init()
        {
            CommandSender.Instance.Init();
        }

        // �ھ��鿪ʼǰ�����ú���ľ��������ļ�
        public void SetPlotConfig(CommandConfig plotConfig)
        {
            CommandSender.Instance.commandConfig = plotConfig;
        }

        // �ھ��鿪ʼǰ�����ú���ľ��������ļ���·����Resources�ļ�����
        public void SetPlotConfig(string plotConfigPath)
        {
            CommandConfig commandConfig = GameModule.Resource.LoadAsset<CommandConfig>(plotConfigPath);
            // CommandConfig commandConfig = Resources.Load<CommandConfig>(plotConfigPath);
            if (commandConfig == null)
            {
                Debug.LogError("SetPlotConfig : path invalid.");
                return;
            }

            SetPlotConfig(commandConfig);
        }


        /// ������Ļ�ֱ��ʴ�С
        public void SetPixel(Vector2 screenPixel)
        {
            AvgSettingConfig.pixelSize = screenPixel;
        }

        // ����Ч����ʱ�������Ƽ���ΧΪ 0.01f - 0.1f
        public void SetTypingTimeDevision(float t)
        {
            AvgSettingConfig.typingEffectTimeDevision = t;
        }

        public List<int> GetPlayerDecisions()
        {
            return AvgUISettings.Instance.playerDecisions;
        }
    }
}