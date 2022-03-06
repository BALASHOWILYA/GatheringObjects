using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SquareHandler : MonoBehaviour
{
    [SerializeField] private Rigidbody2D squareRidgidbody;

    private Camera _mainCamera;
    private Vector2 _pos;

    private void Start()
    {
        _mainCamera = Camera.main;
    }

    private void Update()
    {
        
        if (squareRidgidbody == null) return;

        if (!Touchscreen.current.primaryTouch.press.isPressed) return;
        
        Vector2 touchPosition = Touchscreen.current.primaryTouch.position.ReadValue();
       
        Vector3 worldPosition = _mainCamera.ScreenToWorldPoint(touchPosition);
                
        squareRidgidbody.position = worldPosition;
           
        
    }

    
}
