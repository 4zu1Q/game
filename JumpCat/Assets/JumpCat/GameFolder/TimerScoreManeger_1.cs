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

//public GameObject score_object = null;  // Textオブジェクト
//public int score_num = 0;   // スコア変数

//// Start is called before the first frame update
//void Start()
//{
//    score_num = PlayerPrefs.GetInt("TIME", 0);  // スコアのロード
//}

//// 削除時の処理
//public void OnDestroy()
//{
//    // スコアの保存
//    PlayerPrefs.SetInt("TIME", score_num);
//    PlayerPrefs.Save();
//}

//// Update is called once per frame
//void Update()
//{
//    // オブジェクトからTextをコンポーネントを取得
//    Text score_text = score_object.GetComponent<Text>();
//    // テキストの表示を入れ替える
//    score_text.text = "TIME" + score_num;

//    score_num += 1;
//}