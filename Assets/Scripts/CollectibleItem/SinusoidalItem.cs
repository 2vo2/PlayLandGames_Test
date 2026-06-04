using System;
using UnityEngine;

public class SinusoidalItem : BaseCollactableItem, IAnimatable
{
    [SerializeField] private float _amplitude;
    [SerializeField] private float _frequency;

    private Vector3 _startPosition;

    private void Start()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        Animation();
    }

    public void Animation()
    {
        var sinY = _startPosition.y + Mathf.Sin(Time.time * _frequency) * _amplitude;

        transform.position = new Vector3(_startPosition.x, sinY, _startPosition.z);
    }
}
