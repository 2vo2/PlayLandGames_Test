using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;

    private void OnEnable()
    {
        ScoreHandler.Instance.OnScoreChanged += ShowScore;
    }

    private void Osable()
    {
        ScoreHandler.Instance.OnScoreChanged -= ShowScore;
    }

    private void ShowScore(int scoreValue)
    {
        _scoreText.text = $"Score: {scoreValue}";
    }
}
