using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForMouseButtonDown : CustomYieldInstruction
{
    private int curr;   // ��ǰ�����������
    private int max;    // ���������������

    public WaitForMouseButtonDown(int max)
    {
        curr = 0;
        this.max = max;
    }

    public override bool keepWaiting => CheckKeepWaiting(); // ÿһ֡����������һ��
                                                            // ���״̬
    private bool CheckKeepWaiting()
    {
        if (curr >= max)    // ˵������������
        {
            return false;   // ����Ҫ�����˵ȴ�״̬��
        }
        if (Input.GetMouseButtonDown(0))
        {
            curr++; // ���������
        }
        return true;    // ���ֵȴ�״̬
    }
}