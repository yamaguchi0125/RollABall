using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class JoystickController : MonoBehaviour, IDragHandler
{
	// ���S����̍ő勗��
	public float maxDistance;

	// �N���b�N�����o�I�ɕ\������
	public Transform joystickHandle;

	// Vector2�������Ɏ��UnityEvent���쐬
	[Serializable]
	public class Vector2UnityEvent : UnityEvent<Vector2> { }

	// �W���C�X�e�B�b�N�̒l��XY��-1�`1�V�X�e���ň����Ɏ��C�x���g
	public Vector2UnityEvent JoystickOutput;

	// �w����ʏ�Ńh���b�O����邽�тɌĂяo�����֐�
	public void OnDrag(PointerEventData eventData)
	{

	}

	// ����܂ł̃t�B�[���h�ƃ��\�b�h�c
	// �n���h���̃��[�J���ʒu�̌��ς�����v�Z
	public Vector3 GetPosition(Vector3 userInput)
	{
		Vector3 dir = userInput - transform.position;

		if (Vector3.SqrMagnitude(dir) > maxDistance * maxDistance)
		{
			dir = dir.normalized * maxDistance;
		}

		return dir;
	}

	// �w����ʏ�Ńh���b�O����邽�тɌĂяo�����֐�
	public void OnDrag(PointerEventData eventData)
	{
		// �����Ń��[�J���ʒu��T�d�ɐݒ肷��
		joystickHandle.localPosition = GetPosition(eventData.position);
	}


}

