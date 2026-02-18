using UnityEngine;

public class BrickBehavior : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            GameBehavior.Instance.Points += 10; 
            Destroy(gameObject);
        }
    }
}