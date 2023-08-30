using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    [SerializeField]
    public static int minute;
    [SerializeField]
    public static float seconds;
    // �O��Update�̎��̕b��
    public static float oldSeconds;
    // �^�C�}�[�\���e�L�X�g
    Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        minute = 0;
        seconds = 0.0f;
        oldSeconds = 0.0f;
        timerText = GetComponentInChildren<Text>();
    }

    void Update()
    {
        seconds += Time.deltaTime;
        if (seconds >= 60.0f)
        {
            minute++;
            seconds = seconds - 60;
        }
        // �l���ς�����������e�L�X�gUI���X�V
        if ((int)seconds != (int)oldSeconds)
        {
            timerText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        }
        oldSeconds = seconds;
    }
}
