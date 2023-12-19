using System;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private InputActions _inputActions;

    private void Awake()
    {
        _inputActions = new();
    }
}
