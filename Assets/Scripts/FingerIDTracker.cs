using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FingerIDTracker : MonoBehaviour
{
	// カメラへのアクセス
	public int trackedFingerId;

	// タッチを引数として使うUnityEvent
	[SerializeField]
	public class Vector3UnityEvent : UnityEvent<Vector3> { }

	// トラッキングしている指が画面に触れたときに呼び出される
	public Vector3UnityEvent touchDetected;

	// スクリプトが有効になった際に毎回呼び出される
	public void Update()
	{
		int touchCount = Input.touchCount;

		for (int i = 0; i < touchCount; i++)
		{
			if (Input.GetTouch(i).fingerId == trackedFingerId)
			{
				touchDetected.Invoke(Input.GetTouch(i).position);
			}
		}
	}
}

