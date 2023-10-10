using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : MonoBehaviour
{

    Vector3 arrow;
    float angleZ;

    // Start is called before the first frame update
    void Start()
    {
        arrow = new Vector3(0, 0, 0);
        angleZ = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        angleZ = angleZ + 0.1f;
        this.transform.rotation = Quaternion.Euler(180, 0, angleZ);

        if (angleZ > 360)
        {
            angleZ = 0.1f;
        }
    }
}
