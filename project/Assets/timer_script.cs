using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer_script : MonoBehaviour
{
    [SerializeField] private Text timer;
    private float startTime;
    public bool is_stop = false;
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        PlayerPrefs.SetFloat("Score", 0);
    }

    public void stop_time()
    {
        is_stop = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Safe_Zone").GetComponent<GetAttacked>().life > 0 && is_stop == false) {
            PlayerPrefs.SetFloat("Score", Time.time - startTime);

            string minutes = ((int)PlayerPrefs.GetFloat("Score", 0) / 60).ToString();
            string seconds = (PlayerPrefs.GetFloat("Score", 0) % 60).ToString("f2");

            timer.text = "Timer : " + minutes + ":" + seconds;
        }
    }
}
