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
        //DoWhileLoop();
        Enshu1();

    }

    void ForLoop()
    {
        for (int counter = 1; counter <= 100; counter++)
        {
            Debug.Log(counter);
        }
        Debug.Log("���[�v���I�������܂�");

        for (int counter = 2; counter <= 100; counter += 2)
        {
            Debug.Log(counter);
        }
        Debug.Log("���[�v���I�������܂�");
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
        int counter = 200;
        Debug.Log("do while���[�v��1�`100�܂Ő����܂�");
        do
        {
            Debug.Log(counter);
            counter += 1;
        } while (counter <= 100);
        Debug.Log("do while���[�v���I�����܂�");
    }

    void Enshu1()
    {
        int n = 8;

        while(n > 0)
        {
            if((n % 2) == 0)
            {
                n /= 2;
            }
            else
            {
                n -= 1;
            }
            Debug.Log(n);
        }
    }


}
