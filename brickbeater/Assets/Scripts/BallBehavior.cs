using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public float Speed = 3.0f;


    private Vector2 direction;
    
    
void Start()
{
    if (Random.value > 0.5f)
    {
        direction.y = 1;
    }
    else
    {
        direction.y = -1;
    }

    // Ternary operator ; condition ? pass : fail
    direction.y = Random.value > 0.5f ? 1 : -1;
    direction.x = Random.value > 0.5f ? 1 : -1;
}

void Update()
{
    Vector3 movement = direction * Speed * Time.deltaTime;
    transform.Translate(movement);
}
}
