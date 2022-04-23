using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public bool isJumping;
    public bool isRunning;
    public bool isPaused;

    public GameManager gameManager;

    int food = 0;

    private void Update()
    {
        if(food == 10)
        {
            gameManager.Won();
        }
    }

    public void OnPause(InputValue value)
    {
        if (isPaused)
        {
            isPaused = false;
        }
        else
        {
            isPaused = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            gameManager.time += 3;
            food++;
            other.gameObject.SetActive(false);
        }
    }
}
