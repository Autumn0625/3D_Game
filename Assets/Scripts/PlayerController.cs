using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private ControllerMovement3D _controllMovement;
    private Vector3 _movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        _controllMovement = GetComponent<ControllerMovement3D>();
    }
    public void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        _movement = new Vector3(input.x, 0f, input.y);
    }
    public void OnJump(InputValue value)
    {
        _controllMovement.Jump();
    }
    // Update is called once per frame
    void Update()
    {
        if (_controllMovement == null) return;

        _controllMovement.SetMoveInput(_movement);
        _controllMovement.SetLookDirection(_movement);
    }
}
