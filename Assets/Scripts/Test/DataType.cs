using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType : MonoBehaviour
{
    //int 整数
    int integerNumber;
    //float 小数(第7位まで)
    float floatNumber;
    // double: 小数(第15位まで)
    double doubleNumber;

    // char: 文字(1文字)
    char character;
    // string: 文字列
    string stringData;


    //演習
    float number1;
    int number2;


    // Start is called before the first frame update
    void Start()
    {
        integerNumber = 8;
        Debug.Log(integerNumber);

        floatNumber = 1.5f;
        Debug.Log(floatNumber);

        doubleNumber = 1.234567890123;
        Debug.Log(doubleNumber);

        character = 'u';
        Debug.Log(character);

        stringData = "unity";
        Debug.Log(stringData);

        Debug.Log("C:Users\\Username\\Documents");

        number1 = 12.34f;
        number2 = (int)number1;
        Debug.Log(number2);

    }
}

