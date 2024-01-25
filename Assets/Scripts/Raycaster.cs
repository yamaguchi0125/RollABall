using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
	// カメラへのアクセス
	public Camera usedCamera;

	// スクリプトが有効になった際に毎回呼び出される
	public void OnEnable()
	{
		if (!usedCamera)
		{
			usedCamera = Camera.main;
		}
	}

	// 毎フレーム呼び出される
	public void DrawRay(Vector3 clickPosition)
	{
		// mousePositionからレイを作成
		Ray ray = usedCamera.ScreenPointToRay(clickPosition);

		// Rayと一致する線を描画
		Debug.DrawRay(ray.origin, ray.direction);
	}
}
