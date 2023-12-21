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
        //�X�y�[�X�L�[�����ꂽ��
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            //�g���K�[on�ɂ���
            this.remyAnimator.SetTrigger("ChangeIdleWalkingState");
        }
    }
}
