using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bootstraper : MonoBehaviour
{
    [SerializeField] private ScoreHandler _scoreHandler;

    private void Awake()
    {
        Instantiate(_scoreHandler);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
