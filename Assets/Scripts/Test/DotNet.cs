using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotNet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowTime();
    }
    void ShowTime()
    {
        DateTime now = DateTime.Now; // ���̎��Ԃ��擾����
        Debug.Log(now); // ���̎��Ԃ��Q�[���ɕ\������
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
