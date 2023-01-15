using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    Image timeBar;
    public float maxTime = 30f;
    float timeLeft;
    public GameObject timesUpText;

    void Start()
    {
        timesUpText.SetActive(false);
        timeBar = GetComponent<Image>();
        timeLeft = maxTime;
    }

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timeBar.fillAmount = timeLeft / maxTime;

        }
        else
        {
            timesUpText.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
