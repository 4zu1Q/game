using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        speed = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (HandButton.Count > 0)
        {
            CookieButton.Count = CookieButton.Count + 1;
        }

        if (GranmaButton.Count > 0)
        {
            CookieButton.Count = CookieButton.Count + 5;
        }

        if (FactoryButton.Count > 0)
        {
            CookieButton.Count = CookieButton.Count + 80;
        }
    }
}
