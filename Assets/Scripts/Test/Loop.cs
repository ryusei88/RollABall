using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ForLoop();
        //ForeachLoop();
        //WhileLoop();
        DoWhileLoop();
    }
    void ForLoop()
    {
        Debug.Log("1~100�܂Ő����܂�");
        for (int counter = 1; counter <= 100; counter++)
        {
            Debug.Log(counter);
        }
        Debug.Log("for���[�v���I�����܂�");
    }

    void ForeachLoop()
    {
        int[] scores = { 50, 80, 60, 80, 90 };
        foreach (var score in scores)
        {
            Debug.Log(score);// 50,80,60,80,90
        }
    }

    void WhileLoop()
    {
        /* while(����): ������true�ł���ꍇ�A�������J��Ԃ�
        */
        Debug.Log("while���[�v��1~100�܂Ő����܂�");
        int counter = 1;
        while (counter <= 100)
        {
            Debug.Log(counter);
            counter += 1;
        }
        Debug.Log("while���[�v���I�����܂�");
    }

    void DoWhileLoop()
    {
        /* do{}while(����);: �ŏ��Ɉ�x�K���������s���B���̌�A������true�ł���ꍇ�A�������J��Ԃ�
        */
        int counter = 200;
        Debug.Log("do while���[�v��1~100�܂Ő����܂�");
        do
        {
            Debug.Log(counter);
            counter += 1;
        } while (counter <= 100);
        Debug.Log("do while���[�v���I�����܂�");
    }
}
