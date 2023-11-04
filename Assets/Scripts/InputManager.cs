using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    PlayerInputActions playerInputActions;
    private void OnEnable()
    {
    }
    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Enable();
    }
    public Vector2 GetMovementVector()
    {
        return playerInputActions.Player.Movement.ReadValue<Vector2>();
    }
}
