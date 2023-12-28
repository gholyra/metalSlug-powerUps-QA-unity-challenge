using System;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    public static PlayerBehaviour Instance;

    [SerializeField] private InputManager inputManager;
    [SerializeField] private float moveVelocity = 3f;

    private Transform transform;
    private Rigidbody2D rigidBody;

    private Vector2 moveDirection;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = null;
        }
        transform = GetComponent<Transform>();
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        moveDirection.x = inputManager.GetMovementDirection();

        // isWalking = moveDirection.x != 0;

        // if (moveDirection.x > 0)
        // {
        //     playerSprite.flipX = false;
        // }
        // else if (moveDirection.x < 0)
        // {
        //     playerSprite.flipX = true;
        // }

        transform.Translate(moveDirection * moveVelocity * Time.deltaTime);
    }
}
