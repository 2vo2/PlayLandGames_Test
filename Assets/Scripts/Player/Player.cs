using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _clampX;

    private void Update()
    {
       ClampPosition();
    }

    private void ClampPosition()
    {
        var clampX = Mathf.Clamp(transform.position.x, -_clampX, _clampX);
        transform.position = new Vector3(clampX, transform.position.y, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<BaseCollactableItem>(out BaseCollactableItem item))
        {
            item.Collect();
        }
    }
}
