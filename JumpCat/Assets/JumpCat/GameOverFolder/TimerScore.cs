using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScore : MonoBehaviour
{
    Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponentInChildren<Text>();

        ScoreText.text = "‹L˜^..." + Timer.minute.ToString("00") + ":" + ((int)Timer.seconds).ToString("00");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
