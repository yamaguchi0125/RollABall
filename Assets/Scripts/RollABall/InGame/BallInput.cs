using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallInput : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        /*// �V����Input System���g�p����"W"�L�[�̓��͂����m
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            Debug.Log("W�L�[��������܂���!");
        }*/

        // W�L�[�������ꑱ���Ă����
        if (Keyboard.current.wKey.isPressed)
        {
            Debug.Log("W�L�[�������ꑱ���Ă܂�!");
        }
        // A�L�[�������ꑱ���Ă����
        if (Keyboard.current.aKey.isPressed)
        {
            Debug.Log("A�L�[�������ꑱ���Ă܂�!");
        }
        // S�L�[�������ꑱ���Ă����
        if (Keyboard.current.sKey.isPressed)
        {
            Debug.Log("S�L�[�������ꑱ���Ă܂�!");
        }
        // D�L�[�������ꑱ���Ă����
        if (Keyboard.current.dKey.isPressed)
        {
            Debug.Log("D�L�[�������ꑱ���Ă܂�!");
        }


        /*// W�L�[�������ꂽ�u�Ԃ����]������
        if (Keyboard.current.wKey.wasReleasedThisFrame)
        {
            Debug.Log("W�L�[��������܂���!");
        }*/

       /* Vector2 mousePosition = Mouse.current.position.ReadValue();
        Debug.Log($"�}�E�X�̍��W: {mousePosition}");*/
    }
}
