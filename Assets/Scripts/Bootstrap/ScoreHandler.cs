using System;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    public static ScoreHandler Instance {get; private set;}

    private int _currentScore;

    public int CurrentScore => _currentScore;

    public event Action<int> OnScoreChanged;

    private void Awake()
    {
        if (Instance != null) Destroy(this);
        Instance = this;
        DontDestroyOnLoad(this);
    }

    public void AddScore(int scoreValue)
    {
        if (scoreValue < 0) return;

        _currentScore += scoreValue;
        OnScoreChanged?.Invoke(_currentScore);
    }
}
