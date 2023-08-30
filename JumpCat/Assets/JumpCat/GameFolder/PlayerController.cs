using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //�C���X�y�N�^�[�Őݒ肷��
    public float speed;
    public GroundCheck ground;

    //�v���C�x�[�g�ϐ�
    private Animator anim = null;
    private Rigidbody2D rb = null;
    private bool isGround = false;


    // Start is called before the first frame update
    void Start()
    {
        //�R���|�[�l���g�̃C���X�^���X��߂܂���
        //anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //�ڒn����𓾂�
        isGround = ground.IsGround();

        //�L�[���͂��ꂽ��s������
        float horizontalKey = Input.GetAxis("Horizontal");
        float xSpeed = 0.0f;
        if (horizontalKey > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
            anim.SetBool("run", true);
            xSpeed = speed;
        }
        else if (horizontalKey < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            anim.SetBool("run", true);
            xSpeed = -speed;
        }
        else
        {
            anim.SetBool("run", false);
            xSpeed = 0.0f;
        }
        rb.velocity = new Vector2(xSpeed, rb.velocity.y);
    }
}
