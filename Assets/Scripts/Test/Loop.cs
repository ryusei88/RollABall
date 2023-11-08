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
        Debug.Log("1~100まで数えます");
        for (int counter = 1; counter <= 100; counter++)
        {
            Debug.Log(counter);
        }
        Debug.Log("forループを終了します");
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
        /* while(条件): 条件がtrueである場合、処理を繰り返す
        */
        Debug.Log("whileループで1~100まで数えます");
        int counter = 1;
        while (counter <= 100)
        {
            Debug.Log(counter);
            counter += 1;
        }
        Debug.Log("whileループを終了します");
    }

    void DoWhileLoop()
    {
        /* do{}while(条件);: 最初に一度必ず処理を行う。その後、条件がtrueである場合、処理を繰り返す
        */
        int counter = 200;
        Debug.Log("do whileループで1~100まで数えます");
        do
        {
            Debug.Log(counter);
            counter += 1;
        } while (counter <= 100);
        Debug.Log("do whileループを終了します");
    }
}
