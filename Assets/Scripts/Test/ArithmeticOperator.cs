using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArithmeticOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(1 + 2);
        Debug.Log(30 - 29);
        Debug.Log(9 * 9);
        Debug.Log(120 / 5);
        Debug.Log(120 / 7);
        Debug.Log(120 % 7);

        int sum = 5 + 13;
        Debug.Log(sum);
        sum = sum + 1;
        Debug.Log(sum);
        sum += 1;
        Debug.Log(sum); // 20
        int number = 23; // 0����51�܂ł̔C�ӂ̐�
        string[] suits = { "�n�[�g", "�_�C��", "�N���u", "�X�y�[�h" };
        string[] ranks = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10",
"J", "Q", "K"};
        string suit = suits[number / 13];
        string rank = ranks[number % 13];
        Debug.Log($"{suit}��{rank}"); //�_�C����J
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
