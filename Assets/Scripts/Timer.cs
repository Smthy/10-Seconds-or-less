using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float countDown;
    public Text timeText;
    public GameObject gameOver, restart, quit;

    void Awake()
    {
        Time.timeScale = 1f;
    }

    void Start()
    {
        StartCoroutine(TimerSettings());
        countDown = 10f;

        timeText.text = ("Timer: " +countDown.ToString());
    }

    void Update()
    {
        Destroy();
    }

    IEnumerator TimerSettings()
    {
        yield return new WaitForSeconds(1f);
        countDown--;
        Debug.Log(countDown);
        timeText.text = ("Timer: " + countDown.ToString());

        if (countDown <= 0)
        {
            Debug.Log("Nope");
            gameOver.SetActive(true);
            restart.SetActive(true);
            quit.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            StartCoroutine(TimerSettings());
        }
    }

    void Destroy()
    {
        if(countDown <= 0f)
        {
            GameObject[] points = GameObject.FindGameObjectsWithTag("point");
            foreach (GameObject point in points)
            {
                GameObject.Destroy(point);
            }
        }

    }
}
