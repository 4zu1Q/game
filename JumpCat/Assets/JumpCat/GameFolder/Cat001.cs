using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat001 : MonoBehaviour
{
    [SerializeField] GameObject cat001;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Char001.char001 == 1)
        {
            cat001.SetActive(true);
        }
        else
        {
            cat001.SetActive(false);
        }
    }
}
