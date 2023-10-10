using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CookieButton : MonoBehaviour
{
    public static int Count;
    GameObject _Object;
    Text _Text;

    Vector3 arrow;
    float angleZ;
   

    // Start is called before the first frame update
    void Start()
    {
       _Text = GameObject.Find("CookieCount").GetComponent<Text>();
        _Object = GameObject.Find("Cookie").GetComponent<GameObject>();
        arrow = new Vector3(0, 0, 0);
        angleZ = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnClick()
    {
        Count++;
        Debug.Log(Count);
        angleZ = angleZ + 0.1f;
        this.transform.position = transform.position(0, 0, angleZ);
    }

}
