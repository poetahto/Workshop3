using UnityEngine;
using UnityEngine.Events;

public class Collectable : MonoBehaviour
{
    public UnityEvent onCollected;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        onCollected.Invoke();
        gameObject.SetActive(false);
    }
}