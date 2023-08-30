using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyControllerLeft : MonoBehaviour
{
    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        this.Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

        // フレームごとに等速で通過させる
        transform.Translate(0.01f, 0, 0);

        // 画面外に出たらオブジェクトを破壊する
        if (transform.position.x > 12.0f)
        {
            Destroy(gameObject);
        }

        // 当たり判定
        Vector2 p1 = transform.position;                    // 敵の中心座標
        Vector2 p2 = this.Player.transform.position;        // プレイヤーの中心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;    // 敵の半径
        float r2 = 0.4f;    // プレイヤーの半径

        if (d < r1 + r2)
        {
            // 衝突した場合は敵を消す
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
