using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float bigBonusTime = 1f;

    private float bonusTime = 2f;
    private float disappearTime = 5f;

    private int scoreValue = 10; //�ʏ�̃X�R�A�l
    private int bonusScoreValue = 20; //�{�[�i�X�X�R�A�l

    private int bigBonusScoreValue = 100; //�r�b�O�{�[�i�X�X�R�A�l

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
        // �����܂ł̓{�[�i�X�^�C����2�b�҂�
        bonusChances = bonusChance.SmallBonus;
        yield return new WaitForSeconds(bonusTime - bigBonusTime);
        // �����鎞�Ԃ�5�b�Ȃ̂ŁA�{�[�i�X�^�C����2�b�����3�b�҂�
        bonusChances = bonusChance.NoBonus;
        yield return new WaitForSeconds(disappearTime - bonusTime);
        Destroy(this.gameObject);
    }

    //�v���C���[���R�C���ɐG�ꂽ�Ƃ��ɌĂ΂��
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Sphere")
        {
            //�R�C����D��
            Destroy(gameObject);
        }
    }
}
