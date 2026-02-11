using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    [SerializeField] private float _LaunchForce = 3.0f;


    private Vector2 _direction;
    
    private Rigidbody2D _rb;
    
void Start()
{
  _rb = GetComponent<Rigidbody2D>();

    // Ternary operator ; condition ? pass : fail
    _direction.y = Random.value > 0.5f ? 1 : -1;
    _direction.x = Random.value > 0.5f ? 1 : -1;

    _rb.AddForce(_direction * _LaunchForce, ForceMode2D.Impulse);
}

void OnTriggerEnter2D(Collider2D other)
    {
        ResetBall();
    }

void ResetBall()
    {
        _rb.linearVelocity = Vector2.zero;
        transform.position = Vector3.zero;

        Vector2 direction = new Vector2
        (GetNonZeroRandomFloat(), 
        GetNonZeroRandomFloat()).normalized;

        _rb.AddForce(direction * _LaunchForce, ForceMode2D.Impulse);
    }
void Update()
{
    
}
float GetNonZeroRandomFloat(float min = -1.0f, float max = 1.0f)
    {
        float num;

        do
        {
            num = Random.Range(min, max);
        } while (Mathf.Approximately(num, 0.0f));

        return num;
    }
}