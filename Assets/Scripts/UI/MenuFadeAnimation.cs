using System.Collections;
using UnityEngine;

public class MenuFadeAnimation : MonoBehaviour
{
    [SerializeField] private CanvasGroup _canvasGroup;
    [SerializeField] private float _duration;
    

    private void Start()
    {
        StartCoroutine(FadeIn());
    }

    private IEnumerator FadeIn()
    {
        var elapsedTime = 0f;

        while (elapsedTime < _duration)
        {
            elapsedTime += Time.deltaTime;
            _canvasGroup.alpha = Mathf.Clamp01(elapsedTime / _duration);
            yield return null;
        }

        _canvasGroup.alpha = 1f;
    }
}
