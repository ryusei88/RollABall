using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperator : MonoBehaviour
{

    bool condition1 = true;
    bool condition2 = false;

    // Start is called before the first frame update
    void Start()
    {
        //CheckCondition();
        if (condition1 && condition2) // false
        {
            Debug.Log("����1�Ə���2��true�ł�"); // false�̂��ߕ\������Ȃ�
        }
        if (condition1 || condition2) // true
        {
            Debug.Log("����1�܂��͏���2��true�ł�"); // true�̂��ߕ\�������
        }

        int a = 10;
        int b = 4;
        if(a >= 10 && a != 15 && b <= 5)
        {

        }

        bool isRaining = true;
        bool hasUmbrella = true;
        if(!isRaining || (isRaining && hasUmbrella))
        {
            Debug.Log("�Ƃ��o��");
        }

    }

    void CheckCondition()
    {
        // &&:�_����(AND)
        Debug.Log(condition1 && condition2);
        // ||:�_���a(OR)
        Debug.Log(condition1 || condition2);
        // !:�ے�(NOT)
        Debug.Log(!condition1);
        // ^:�r���I�_���a(XOR)
        Debug.Log(condition1 ^ condition2);
    }
}
