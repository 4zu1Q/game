using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandButton : MonoBehaviour
{
    public static int Count;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnClick()
    {
        if(CookieButton.Count >= 8)
        {
            CookieButton.Count = CookieButton.Count - 8;
            Count++;
            Debug.Log(Count);
            
        }
        else
        {
        }

    }
}
