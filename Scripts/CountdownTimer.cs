using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timeLeft;
    public bool isTimeGone = false;
    public GameObject loserPanel;
    private Animator anim;

    private void Start()
    {
        anim = GameObject.Find("Player").GetComponent<Animator>();
    }
    private void Update()
    {
        timeLeft -= Time.deltaTime;
        int min = Mathf.FloorToInt(timeLeft / 60);
        int sec = Mathf.FloorToInt(timeLeft % 60);
        timerText.GetComponent<TextMeshProUGUI>().text = min.ToString("0") + ":" + sec.ToString("00");

        if (timeLeft <= 0)
        {
            anim.Play("death");
            isTimeGone = true;
            min = 0;
            sec = 0;
            timerText.GetComponent<TextMeshProUGUI>().text = min.ToString("0") + ":" + sec.ToString("00");
            loserPanel.SetActive(true);
            Invoke("DelayedScreenFrezze", 1.2f);
        }
        else
        {
            isTimeGone = false;
            loserPanel.SetActive(false);
        }
    }

    void DelayedScreenFrezze()
    {
        Time.timeScale = 0f;
    }
}
