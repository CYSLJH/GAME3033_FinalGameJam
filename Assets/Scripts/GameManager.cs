using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public float time;

    public bool objectiveComplete = false;  

    public GameObject winPanel;
    public GameObject losePanel;
    public GameObject pausePanel;

    public PlayerController playerController;

    public TextMeshProUGUI timerDisplay;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        ResumeGame();
        winPanel.SetActive(false);
        losePanel.SetActive(false);
    }
    private void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;

        }
        if(time <= 0)
        {
            Lost();
        }

        if(playerController.isPaused)
        {
            PauseGame();
        }
        else if(!playerController.isPaused)
        {
            ResumeGame();
        }

        if (timerDisplay != null)
        {
            timerDisplay.SetText("Time Left: " + Mathf.Round(time)); //round to whole number
        }
    }

    public void PauseGame()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void Won()
    {
        winPanel.SetActive(true);
        losePanel.SetActive(false);
    }

    public void Lost()
    {
        losePanel.SetActive(true);
        winPanel.SetActive(false);
    }
}
