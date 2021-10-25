using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    [SerializeField] private string mainMenuName;
    
    private int _remainingCollectables;
    
    private void Start()
    {
        Collectable[] collectables = FindObjectsOfType<Collectable>();
        
        foreach (var collectable in collectables)
            collectable.onCollected.AddListener(OnCoinCollected);

        _remainingCollectables = collectables.Length;
    }

    private void OnDestroy()
    {
        Collectable[] collectables = FindObjectsOfType<Collectable>();
        
        foreach (var collectable in collectables)
            collectable.onCollected.RemoveListener(OnCoinCollected);
    }

    private void OnCoinCollected()
    {
        _remainingCollectables--;

        if (_remainingCollectables <= 0)
            SceneManager.LoadScene(mainMenuName);
    }
}