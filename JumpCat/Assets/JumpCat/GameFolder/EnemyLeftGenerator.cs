using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLeftGenerator : MonoBehaviour
{
    public GameObject enemyLeftPrefab;
    float span = 0.8f;
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
            GameObject go = Instantiate(enemyLeftPrefab) as GameObject;
            float py = Random.Range(-3.5f, 0.0f);
            go.transform.position = new Vector3(-12, py, 0);
        }
    }
}
