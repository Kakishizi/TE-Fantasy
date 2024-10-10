using UnityEngine;
using AVG_module;
using UnityEditor;

public class Entry : MonoBehaviour
{

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            AVGModule.Instance.Init();
            AVGModule.Instance.SetPlotConfig("Novel-1");
            AVGModule.Instance.plotBegin.Invoke();
        }
    }




}
