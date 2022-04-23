using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public bool isFiring;
    public bool isReloading;
    public bool isJumping;
    public bool isRunning;
    public bool isAiming;
    public bool inInventory;
    public bool isPaused;

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
}
