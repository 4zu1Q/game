using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItmeController : MonoBehaviour
{
    GameObject Player;
    [SerializeField]
    public GameObject EnemyR;
    [SerializeField]
    public GameObject EnemyL;

    //float effectTime = 15.0f;
    //float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.Player = GameObject.Find("Player");
        this.EnemyL = GameObject.Find("EnemyLeft");
        this.EnemyR = GameObject.Find("EnemyRight");
    }

    // Update is called once per frame
    void Update()
    {
        // フレームごとに等速で通過させる
        transform.Translate(0, -0.01f, 0);

        // 当たり判定
        Vector2 p1 = transform.position;                    // アイテムの中心座標
        Vector2 p2 = this.Player.transform.position;        // プレイヤーの中心座標
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;    // アイテムの半径
        float r2 = 0.4f;    // プレイヤーの半径

        if (d < r1 + r2)
        {
            // 衝突した場合はアイテムを消す
            Destroy(gameObject);

            //delta += Time.deltaTime;


            //    Debug.Log("効果時間");
            //    EnemyL.transform.Translate(0.001f, 0, 0);
            //    EnemyR.transform.Translate(-0.001f, 0, 0);

        }
    }
}
