using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI counterText;
    [SerializeField] float remainingTime;

    public GameObject GameOverScreen;

    public void Awake()
    {
        GameOverScreen.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (remainingTime >0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            GameOverScreen.SetActive(true);
        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        counterText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
