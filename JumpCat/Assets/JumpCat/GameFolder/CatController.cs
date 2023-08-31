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

    int jumpCount = 0;          // �W�����v��
    float jumpForce = 620.0f;   // �W�����v��
    public float walkForce = 15.0f;   // ����
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
        // �W�����v����
        if(Input.GetKeyDown(KeyCode.Space) && 
            this.jumpCount < 2) 
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
            jumpCount++;
            // ����炷
            //audioSource.PlayOneShot(jumpSe);
        }

        // ���L�[���������獶�����֐i��
        if (Input.GetKey(KeyCode.A))
        {
            playerSpeed = -speed;
            renderer.flipX = true;
        }
        // �E�L�[����������E�����֐i��
        else if (Input.GetKey(KeyCode.D))
        {
            playerSpeed = speed;
            renderer.flipX = false;
        }
        // ���������Ȃ�������~�܂�
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
        //���E�ړ�
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

        // �L�̑��x
        float speedX = Mathf.Abs(this.rigid2D.velocity.x);

        // �X�s�[�h����
        if (speedX < this.walkForce)
        {
            this.rigid2D.AddForce(transform.right * key);
        }

        //���������ɉ����Ĕ��]
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }
        */