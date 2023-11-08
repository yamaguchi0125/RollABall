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
        DateTime now = DateTime.Now; // ¡‚ÌŠÔ‚ğæ“¾‚·‚é
        Debug.Log(now); // ¡‚ÌŠÔ‚ğƒQ[ƒ€‚É•\¦‚·‚é
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
