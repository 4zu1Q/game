using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScoreManeger_1: MonoBehaviour
{
    public static float timerScore = 100;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}

//public GameObject score_object = null;  // Text�I�u�W�F�N�g
//public int score_num = 0;   // �X�R�A�ϐ�

//// Start is called before the first frame update
//void Start()
//{
//    score_num = PlayerPrefs.GetInt("TIME", 0);  // �X�R�A�̃��[�h
//}

//// �폜���̏���
//public void OnDestroy()
//{
//    // �X�R�A�̕ۑ�
//    PlayerPrefs.SetInt("TIME", score_num);
//    PlayerPrefs.Save();
//}

//// Update is called once per frame
//void Update()
//{
//    // �I�u�W�F�N�g����Text���R���|�[�l���g���擾
//    Text score_text = score_object.GetComponent<Text>();
//    // �e�L�X�g�̕\�������ւ���
//    score_text.text = "TIME" + score_num;

//    score_num += 1;
//}