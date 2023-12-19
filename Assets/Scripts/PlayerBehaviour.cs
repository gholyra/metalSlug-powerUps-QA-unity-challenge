using System;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    [SerializeField] private InputManager inputManager;

    private Transform transform;
    private Rigidbody2D rigidBody;
    
    private void Awake()
    {
        transform = GetComponent<Transform>();
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        throw new NotImplementedException();
    }

    private void Update()
    {
        
    }
}
