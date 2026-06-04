using UnityEngine;

public class BaseCollactableItem : MonoBehaviour, ICollectable
{
    [SerializeField] private int _rewardValue;

    public virtual void Collect()
    {
        gameObject.SetActive(false);
    }
}
