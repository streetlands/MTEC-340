using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    [SerializeField] private float _launchForce = 3.0f;
    [SerializeField] private float _paddleInfluence = 0.3f;
    [SerializeField] private float _speedMultiplier = 1.1f;

    private Rigidbody2D _rb;

void Start()
{
    _rb = GetComponent<Rigidbody2D>();

    Vector2 direction = Random.insideUnitCircle;

    if (Mathf.Abs(direction.x) < 0.25f)
    {
        direction.x += 0.5f * Mathf.Sign(direction.x);
    }

    _rb.AddForce(direction.normalized * _launchForce, ForceMode2D.Impulse);
}

private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Paddle"))
        {
            if (!Mathf.Approximately(other.rigidbody.linearVelocity.y, 0.0f))
            {
                Debug.Log(other.rigidbody);

                Vector2 direction = _rb.linearVelocity * (1.0f - _paddleInfluence)
                    + other.rigidbody.linearVelocity * _paddleInfluence;

                _rb.linearVelocity = _rb.linearVelocity.magnitude * direction.normalized;
            }

            _rb.linearVelocity *= _speedMultiplier;
        }
    }

        void OnTriggerEnter2D(Collider2D other)
        {
            GameBehavior.Instance.Score();

            Destroy(gameObject);
        }
}