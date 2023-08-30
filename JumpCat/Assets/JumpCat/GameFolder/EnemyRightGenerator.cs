using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRightGenerator : MonoBehaviour
{
    public GameObject enemyRightPrefab;
    float span = 1.0f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;

            GameObject go = Instantiate(enemyRightPrefab) as GameObject;
            float py = Random.Range(-3.5f, 0.0f);
            go.transform.position = new Vector3(12, py, 0);

        }
    }
}
