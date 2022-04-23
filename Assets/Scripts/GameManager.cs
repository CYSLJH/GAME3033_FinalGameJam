using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public float time;
    public string objective;

    public bool GameWon = false;
    public bool GameLost = false;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        ResumeGame();
    }
    private void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;

        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
