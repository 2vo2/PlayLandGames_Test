using UnityEngine;

public abstract class BaseCollactableItem : MonoBehaviour, ICollectable, IAnimatable
{
    [SerializeField] private int _rewardValue;

    public void Update()
    {
        Animation();
    }

    public abstract void Animation();

    public virtual void Collect()
    {
        gameObject.SetActive(false);
        ScoreHandler.Instance.AddScore(_rewardValue);
    }
}
