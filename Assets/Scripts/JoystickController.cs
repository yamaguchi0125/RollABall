using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class JoystickController : MonoBehaviour, IDragHandler
{
	// 中心からの最大距離
	public float maxDistance;

	// クリックを視覚的に表現する
	public Transform joystickHandle;

	// Vector2を引数に取るUnityEventを作成
	[Serializable]
	public class Vector2UnityEvent : UnityEvent<Vector2> { }

	// ジョイスティックの値をXYと-1～1システムで引数に取るイベント
	public Vector2UnityEvent JoystickOutput;

	// 指が画面上でドラッグされるたびに呼び出される関数
	public void OnDrag(PointerEventData eventData)
	{

	}

	// これまでのフィールドとメソッド…
	// ハンドルのローカル位置の見積もりを計算
	public Vector3 GetPosition(Vector3 userInput)
	{
		Vector3 dir = userInput - transform.position;

		if (Vector3.SqrMagnitude(dir) > maxDistance * maxDistance)
		{
			dir = dir.normalized * maxDistance;
		}

		return dir;
	}

	// 指が画面上でドラッグされるたびに呼び出される関数
	public void OnDrag(PointerEventData eventData)
	{
		// ここでローカル位置を慎重に設定する
		joystickHandle.localPosition = GetPosition(eventData.position);
	}


}

