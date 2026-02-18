using UnityEngine;

public class PaddleBehavior : MonoBehaviour
{
    public float Speed = 5.0f; 

    public KeyCode LeftDirection = KeyCode.A;
    public KeyCode RightDirection = KeyCode.D;

    // Reference to the paddle's Rigidbody2D
    private Rigidbody2D _rb;

    void Start()
    {
        // Grab the Rigidbody2D component when the game starts
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float movement = 0.0f;
        
        if (Input.GetKey(LeftDirection))
        {
            movement -= Speed;
        }

        if (Input.GetKey(RightDirection))
        {
            movement += Speed;
        }

        _rb.linearVelocity = new Vector2(movement, 0.0f);
    }
}