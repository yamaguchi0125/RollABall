using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventPublisher : MonoBehaviour
{
    // ���A�N�V�����������N�����C�x���g
    public UnityEvent Published;

    // �C�x���g���g���K�[���郁�\�b�h
    public void Publish()
    {
        Published?.Invoke();
    }

}
