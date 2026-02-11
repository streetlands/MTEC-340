using UnityEngine;

public class PaddleBehavior : MonoBehaviour
{

    [SerializeField] private float Speed = 5.0f; 
    [SerializeField] private KeyCode UpDirection = KeyCode.W;
    [SerializeField] private KeyCode DownDirection = KeyCode.S;
private Rigidbody2D _rb;
    private float _direction;
    private void Start()
    {
       _rb = GetComponent<Rigidbody2D>(); 
    }

        private void FixedUpdate()
        {
            _rb.linearVelocity = new Vector2(_rb.linearVelocity.x, _direction * Speed);
            Debug.Log(_rb.linearVelocity.y);
        }
    
        private void Update()
        {
            _direction = 0.0f;
            if (Input.GetKey(UpDirection))
            {
                _direction += 1.0f;
            }
    
            if (Input.GetKey(DownDirection))
            {
                _direction -= 1.0f;
            }
        }
    }