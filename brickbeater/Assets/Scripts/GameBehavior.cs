using UnityEngine;
using TMPro; 

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
        Points = 0;
    }

    private void Serve()
    {
        Instantiate(_ballPrefab, Vector3.zero, Quaternion.identity);
    }

    public void Score()
    {
        Invoke(nameof(Serve), 2.0f);
    }

    [Header("UI Settings")]
    [SerializeField] private TMP_Text _scoreTextUI;

    private int _points = 0;
    
    public int Points
    {
        get { return _points; }
        set
        {
            _points = value;
            if (_scoreTextUI != null)
            {
                _scoreTextUI.text = "Score: " + _points;
            }
        }
    }
}