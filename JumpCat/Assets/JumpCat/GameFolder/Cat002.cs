using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat002 : MonoBehaviour
{
    [SerializeField] GameObject cat002;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Char002.char002 == 1)
        {
            cat002.SetActive(true);
        }
        else
        {
            cat002.SetActive(false);
        }
    }
}
