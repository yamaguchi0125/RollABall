using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChangeIdleWalkingState : MonoBehaviour
{
    [SerializeField]
    private Animator remyAnimator;

    // Start is called before the first frame update
    void Start()
    {
        this.remyAnimator = this.transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //スペースキー押されたら
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            //トリガーonにする
            this.remyAnimator.SetTrigger("ChangeIdleWalkingState");
        }
    }
}
