using UnityEngine;

public class RotateItem : BaseCollactableItem, IAnimatable
{
    [SerializeField] private float _rotationSpeed;

    public override void Animation()
    {
        transform.Rotate(transform.up * _rotationSpeed * Time.deltaTime);
    }
}
