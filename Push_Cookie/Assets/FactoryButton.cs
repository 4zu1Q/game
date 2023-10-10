using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FactoryButton : MonoBehaviour
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
        if (CookieButton.Count >= 800)
        {
            CookieButton.Count = CookieButton.Count - 800;
            Count++;
            Debug.Log(Count);

        }
        else
        {
        }
    }
}
