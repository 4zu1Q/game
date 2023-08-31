using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CatController : MonoBehaviour
{
    AudioSource audioSource;
    Animator animator;
    Rigidbody2D rigid2D;
    public AudioClip jumpSe;
    public AudioClip workSe;
    public SpriteRenderer renderer;

    int jumpCount = 0;          // ジャンプ回数
    float jumpForce = 620.0f;   // ジャンプ力
    public float walkForce = 15.0f;   // 歩き
    public float speed = 15.0f;
    private float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // ジャンプする
        if(Input.GetKeyDown(KeyCode.Space) && 
            this.jumpCount < 2) 
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
            jumpCount++;
            // 音を鳴らす
            //audioSource.PlayOneShot(jumpSe);
        }

        // 左キーを押したら左方向へ進む
        if (Input.GetKey(KeyCode.A))
        {
            playerSpeed = -speed;
            renderer.flipX = true;
        }
        // 右キーを押したら右方向へ進む
        else if (Input.GetKey(KeyCode.D))
        {
            playerSpeed = speed;
            renderer.flipX = false;
        }
        // 何もおさなかったら止まる
        else playerSpeed = 0;

        rigid2D.velocity = new Vector2(playerSpeed, rigid2D.velocity.y);

        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.gameObject.CompareTag("Floor"))
        {
            jumpCount = 0;
        }

    }
}

        /*
        //左右移動
        int key = 0;
        if (Input.GetKey(KeyCode.D))
        {
            key = 1;
            //audioSource.PlayOneShot(workSe);
        };

        if (Input.GetKey(KeyCode.A))
        {
            key = -1;
            //audioSource.PlayOneShot(workSe);
        };

        // 猫の速度
        float speedX = Mathf.Abs(this.rigid2D.velocity.x);

        // スピード制限
        if (speedX < this.walkForce)
        {
            this.rigid2D.AddForce(transform.right * key);
        }

        //動く方向に応じて反転
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }
        */