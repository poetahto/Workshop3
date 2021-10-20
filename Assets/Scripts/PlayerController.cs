using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 1f;
    [SerializeField] private Rigidbody2D playerRigidbody;

    private Vector2 _currentInput;
    private Vector2 _currentVelocity;

    private void Update()
    {
        StoreCurrentInput();
        MoveWithInput();

        playerRigidbody.velocity = _currentVelocity;
    }

    private void StoreCurrentInput()
    {
        _currentInput.x = Input.GetAxisRaw("Horizontal");
        _currentInput.y = Input.GetAxisRaw("Vertical");
    
        _currentInput.Normalize();
    }

    private void MoveWithInput()
    {
        _currentVelocity.x = _currentInput.x * movementSpeed;        
        _currentVelocity.y = _currentInput.y * movementSpeed;
    }
}