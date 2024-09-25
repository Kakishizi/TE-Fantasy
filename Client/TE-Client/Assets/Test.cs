using System.Collections;
using System.Collections.Generic;
using Fantasy;
using Fantasy.Network;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    Scene scene;

    async void Start()
    {
        Fantasy.Platform.Unity.Entry.Initialize();
        scene = await Fantasy.Platform.Unity.Entry.CreateScene();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            scene.Connect("127.0.0.1:20000", NetworkProtocolType.KCP, () =>
            {
                Log.Debug("连接成功");
            }, (() => { Log.Debug("连接失败");}),()=>
            {
                Log.Debug("连接断开");
            }, false, 5000);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            scene.Session.Send(new C2G_TestMessage());
        }
    }
}