using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringConcatenation : MonoBehaviour
{
    string name = "John";
    int age = 20;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My name is John. " + "I'm 20 years old."); //スペース入れると見やすい

        Debug.Log("My name is " + name + ". " + "I'm " + age + " years old.");

        Debug.Log($"My name is {name}. I'm {age} years old.");

        // string.Format
        Debug.Log(string.Format("My name is {0}. I'm {1} years old.", name, age));

        Debug.Log("ダブルクオーテーションマーク\"を表示");

        // @逐語的文字列リテラル
        Debug.Log(@"逐語的文字列リテラルで¥や’を表示、ただし""は例外");
    }

}
