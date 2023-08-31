using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyControllerRight : MonoBehaviour
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
        // �t���[�����Ƃɓ����Œʉ߂�����

        if(ItmeController.itemCount == 0)
        {
            transform.Translate(-0.01f, 0, 0);
        }
        else
        {
            transform.Translate(-0.001f, 0, 0);
        }


        // ��ʊO�ɏo����I�u�W�F�N�g��j�󂷂�
        if (transform.position.x < -12.0f)
        {
            Destroy(gameObject);
        }

        // �����蔻��
        Vector2 p1 = transform.position;                    // �G�̒��S���W
        Vector2 p2 = this.Player.transform.position;        // �v���C���[�̒��S���W
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;    // �G�̔��a
        float r2 = 0.4f;    // �v���C���[�̔��a

        if(d < r1 + r2)
        {
            // �Փ˂����ꍇ�͓G������
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
