using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    int[] testScores = new int[5];
    List<int> testNum = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        testScores[0] = 85;
        testScores[1] = 90;
        testScores[2] = 78;
        testScores[3] = 88;
        testScores[4] = 76;
        Debug.Log(testScores[1]); // 90

        int[] numbers = { 5, 8, 12, 7, 3 };
        Debug.Log(numbers[2]);

        string[] fruits = { "apple", "banana", "cherry", "date", "elderberry" };
        Debug.Log(fruits[2]);

        int[] scores = { 78, 85, 90, 72, 88, 60 };
        int sum = 0;
        foreach (int score in scores)
        {
           sum += score;
        }
        Debug.Log(sum);

        testNum.Add(1);
        testNum.Add(2);
        testNum.Add(3);

        Debug.Log(testNum[0]);

        testNum.Remove(2);

        Debug.Log(testNum.Count);

        List<int> listNumbers = new List<int> {1, 2, 3, 4, 5};
        foreach (int listNumber in listNumbers)
        {
            sum += listNumber;
        }

        List<string> colors = new List<string> { "Red", "Blue", "Green", "Yellow", "Purple" };
        colors.Remove("Green");



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
