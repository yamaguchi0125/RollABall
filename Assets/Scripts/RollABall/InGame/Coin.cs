using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float bigBonusTime = 1f;
    private float bonusTime = 2f;
    private float disappearTime = 5f;

    private int scoreValue = 10;
    private int bonusScoreValue = 20;
    private bool isBonus = true;

    private int bigBonusScoreValue = 100;
    void Start()
    {
        StartCoroutine(BonusTimeCoroutine());
    }
    IEnumerator BonusTimeCoroutine()
    {
        // ボーナスタイム2秒待つ
        yield return new WaitForSeconds(bonusTime);

        // ボーナスタイム終わり
        isBonus = false;
        // 5秒-ボーナスタイム2秒で3秒待つ
        yield return new WaitForSeconds(disappearTime - bonusTime);
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {
            if (isBonus)
            {
                ScoreManager.ScoreCount += bonusScoreValue;
            }
            else
            {
                ScoreManager.ScoreCount += scoreValue;
            }
            Destroy(gameObject);
        }
    }
}
