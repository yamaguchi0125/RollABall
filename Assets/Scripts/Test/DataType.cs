using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType : MonoBehaviour
{
    //int ®”
    int integerNumber;
    //float ¬”(‘æ7ˆÊ‚Ü‚Å)
    float floatNumber;
    // double: ¬”(‘æ15ˆÊ‚Ü‚Å)
    double doubleNumber;

    // char: •¶š(1•¶š)
    char character;
    // string: •¶š—ñ
    string stringData;


    //‰‰K
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

