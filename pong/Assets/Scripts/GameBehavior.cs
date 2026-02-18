using UnityEngine;

public class GameBehavior : MonoBehaviour
{
    public static GameBehavior Instance;

    [SerializeField] private GameObject _ballPrefab;
    
    
    private void Awake()
    {
    if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        Serve();
    }
    private void Serve()
    {
        Instantiate(_ballPrefab, Vector3.zero, Quaternion.identity);
    }

    public void Score()
    {
        Invoke(nameof(Serve), 2.0f);
    }
}
