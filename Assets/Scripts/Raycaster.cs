using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
	// �J�����ւ̃A�N�Z�X
	public Camera usedCamera;

	// �X�N���v�g���L���ɂȂ����ۂɖ���Ăяo�����
	public void OnEnable()
	{
		if (!usedCamera)
		{
			usedCamera = Camera.main;
		}
	}

	// ���t���[���Ăяo�����
	public void DrawRay(Vector3 clickPosition)
	{
		// mousePosition���烌�C���쐬
		Ray ray = usedCamera.ScreenPointToRay(clickPosition);

		// Ray�ƈ�v�������`��
		Debug.DrawRay(ray.origin, ray.direction);
	}
}
