using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItmeGenerator : MonoBehaviour
{
    public GameObject itmePrefab;
    float span = 5.0f;
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

            GameObject go = Instantiate(itmePrefab) as GameObject;
            float px = Random.Range(-3.5f, 4.5f);
            go.transform.position = new Vector3(px, 6.5f, 0);

        }
    }
}
