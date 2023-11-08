using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType : MonoBehaviour
{
    int integerNumber;

    float floatNumber;

    double doubleNumber;

    // Start is called before the first frame update
    void Start()
    {
        integerNumber = 8;
        Debug.Log(integerNumber);
        floatNumber = 1.5f;
        Debug.Log(floatNumber);
        doubleNumber = 1.234567890123;
        Debug.Log(doubleNumber);

        Debug.Log("C:Users\\Username\\Documents");

        float number1 = 12.34f;
        int number2;
        number2 = (int)number1;
        Debug.Log(number2);
    }

   
}
