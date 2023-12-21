using System;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private GameControls gameControls;

    private void Awake()
    {
        gameControls = new GameControls();
        gameControls.Player.Enable();
    }
    
    public float GetMovementDirection()
    {
        float inputValue = gameControls.Player.Walk.ReadValue<float>();
        
        return inputValue;
    }
}
