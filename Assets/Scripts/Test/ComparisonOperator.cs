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
            Debug.Log("x‚Æy‚Í“™‚µ‚¢‚Å‚·"); // false‚Ì‚½‚ß•\Ž¦‚³‚ê‚È‚¢
        }
        trueOrFalse = (x != y);
        if (trueOrFalse) // true
        {
            Debug.Log("x‚Æy‚Í“™‚µ‚­‚È‚¢‚Å‚·"); // true‚Ì‚½‚ß•\Ž¦‚³‚ê‚é
        }

        x = 8;
        y = 3;
        if(x > y)
        {
            Debug.Log("X‚ÍY‚æ‚è‘å‚«‚¢‚Å‚·");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
