using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComparisonOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = 5;
        int y = 8;
        Debug.Log(x == y); // false
        Debug.Log(x != y); // true
        Debug.Log(x > y); // false
        Debug.Log(x < y); // true
        Debug.Log(x >= y); // false
        Debug.Log(x <= y); // true
        Debug.Log(x > 5); // false
        Debug.Log(x >= 5); // true

        bool trueOrFalse = (x == y); //false
        if (trueOrFalse) // false
        {
            Debug.Log("x��y�͓������ł�"); // false�̂��ߕ\������Ȃ�
        }
        trueOrFalse = (x != y);
        if (trueOrFalse) // true
        {
            Debug.Log("x��y�͓������Ȃ��ł�"); // true�̂��ߕ\�������
        }

        x = 8;
        y = 3;
        if(x > y)
        {
            Debug.Log("X��Y���傫���ł�");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
