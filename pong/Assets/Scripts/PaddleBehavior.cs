using UnityEngine;

public class PaddleBehavior : MonoBehaviour
{
    public float Speed = 5.0f; 

    public KeyCode UpDirection = KeyCode.W;
    public KeyCode DownDirection = KeyCode.S;

    void Update()
    {
        float movement = 0.0f;

        if (Input.GetKey(UpDirection))
        {
            movement += Speed;
        }
        if (Input.GetKey(DownDirection))
        {
            movement -= Speed;
        }

            transform.Translate(translation: new Vector3(0.0f, movement, 0.0f) * Time.deltaTime);
        }
    }