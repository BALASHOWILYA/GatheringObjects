using UnityEngine;
using UnityEngine.InputSystem;

public class SquareHandler : MonoBehaviour
{
    [SerializeField] private Rigidbody2D squareRidgidbody;

    private Camera _mainCamera;

    private void Start()
    {
        _mainCamera = Camera.main;
    }

    private void FixedUpdate()
    {
        
        if (squareRidgidbody == null) return;

        if (!Touchscreen.current.primaryTouch.press.isPressed) return;
        
        Vector2 touchPosition = Touchscreen.current.primaryTouch.position.ReadValue();
       
        Vector3 worldPosition = _mainCamera.ScreenToWorldPoint(touchPosition);
                
        squareRidgidbody.position = worldPosition;
            
    }

    
}
