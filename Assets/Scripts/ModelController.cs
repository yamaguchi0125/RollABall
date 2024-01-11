using UnityEngine;
using System.Collections.Generic;

public class ModelController : MonoBehaviour
{
	// �\���\�ȃ��f���̃��X�g
	public List<GameObject> models;

	// ���X�g�̓����ݑI������Ă���Q�[���I�u�W�F�N�g��c�����Ă���
	private int currentIndex;

	// ���X�g�̐擪�̃��f�����ŏ��ɕ\������
	public void Start()
	{
		ChangeModel(0);
	}

	// �\������Ă������f�����\���ɂ��A�V�������f����\������
	public void ChangeModel(int newIndex)
	{
		models[currentIndex].SetActive(false);
		models[newIndex].SetActive(true);

		currentIndex = newIndex;
	}

	//�c.. ���O
	public void Next()
	{
		int nextIndex = currentIndex + 1;

		if (nextIndex >= models.Count)
		{
			nextIndex = 0;
		}

		ChangeModel(nextIndex);
	}

	public void Previous()
	{
		int previousIndex = currentIndex - 1;

		if (previousIndex < 0)
		{
			previousIndex = models.Count - 1;
		}

		ChangeModel(previousIndex);
	}

}


