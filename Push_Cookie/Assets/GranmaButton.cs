using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GranmaButton : MonoBehaviour
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
        if (CookieButton.Count >= 80)
        {
            CookieButton.Count = CookieButton.Count - 80;
            Count++;
            
        }
        else
        {}
    }
}
