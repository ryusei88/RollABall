using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float bigBonusTime = 1f;

    private float bonusTime = 2f;
    private float disappearTime = 5f;

    private int scoreValue = 10; //通常のスコア値
    private int bonusScoreValue = 20; //ボーナススコア値

    private int bigBonusScoreValue = 100; //ビッグボーナススコア値

    private enum bonusChance
    {
        Invalide = -1,
        BigBonus,
        SmallBonus,
        NoBonus
    }

    private bonusChance bonusChances;

    void Start()
    {
        StartCoroutine(BonusTimeCoroutine());
    }

    IEnumerator BonusTimeCoroutine()
    {
        bonusChances = bonusChance.BigBonus;
        yield return new WaitForSeconds(bigBonusTime);
        // ここまではボーナスタイムの2秒待つ
        bonusChances = bonusChance.SmallBonus;
        yield return new WaitForSeconds(bonusTime - bigBonusTime);
        // 消える時間は5秒なので、ボーナスタイムを2秒消費した3秒待つ
        bonusChances = bonusChance.NoBonus;
        yield return new WaitForSeconds(disappearTime - bonusTime);
        Destroy(this.gameObject);
    }

    //プレイヤーがコインに触れたときに呼ばれる
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Sphere")
        {
            //コインを優先
            Destroy(gameObject);
        }
    }
}
