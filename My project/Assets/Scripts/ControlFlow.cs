using UnityEngine; // Removed System.Diagnostics to avoid conflicts

public class ControlFlow : MonoBehaviour
{
    public bool flag;

    void Start()
    {
        if (flag) 
        {
            Debug.Log("Boolean flag is set");
        }
        else
        {
            Debug.Log("Boolean flag isn’t set");
        }

        for (int x = 1; x <= 10; x++)
        {
            int y = (int)Mathf.Pow(2, x); 
            Debug.Log($"The {x} power of 2 is {y}");
        }
    }

    void Update()
    {
        // Update is called once per frame
    }
}