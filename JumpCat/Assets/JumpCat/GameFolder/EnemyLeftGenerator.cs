using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLeftGenerator : MonoBehaviour
{
    public GameObject enemyLeftPrefab;
    float span;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        span = 0;
    }

    // Update is called once per frame
    void Update()
    {
            this.delta += Time.deltaTime;

        if (ItmeController.itemCount == 0)
        {
            span = 2.0f;
        }
        else
        {
            span = 8.0f;
        }

        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(enemyLeftPrefab) as GameObject;
            float py = Random.Range(-3.5f, 0.0f);
            go.transform.position = new Vector3(-12, py, 0);
        }
    }
}
