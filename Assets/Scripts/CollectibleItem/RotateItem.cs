using UnityEngine;

public class RotateItem : BaseCollactableItem, IAnimatable
{
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        Animation();
    }

    public void Animation()
    {
        transform.Rotate(transform.up * _rotationSpeed * Time.deltaTime);
    }
}
