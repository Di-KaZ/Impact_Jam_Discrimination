using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class displayScore : MonoBehaviour
{
    [SerializeField] private Text timer;
    // Start is called before the first frame update
    void Start()
    {
        float time = PlayerPrefs.GetFloat("Score");
        if (time > PlayerPrefs.GetFloat("High Score", 0))
        {
            PlayerPrefs.SetFloat("High Score", time);
        }
    }

    // Update is called once per frame
    void Update()
    {
        string minutesH = ((int)PlayerPrefs.GetFloat("High Score", 0) / 60).ToString();
        string secondsH = (PlayerPrefs.GetFloat("High Score", 0) % 60).ToString("f2");
        string minutes = ((int)PlayerPrefs.GetFloat("Score", 0) / 60).ToString();
        string seconds = (PlayerPrefs.GetFloat("Score", 0) % 60).ToString("f2");
        timer.text = "Your Time : " + minutes + ":" + seconds + " Best Time : " + minutesH + ":" + secondsH;
    }
}
