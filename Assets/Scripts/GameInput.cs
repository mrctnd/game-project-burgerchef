using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{

    private PlayerInputActions playerInputActions;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
    }

    public Vector2 GetMovementVectorNormalized() 
    {
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();

        // normalized = ayný anda iki yön tuþuna basýldýðýnda eþit hýzlarda hareket etmesini saðlar.
        inputVector = inputVector.normalized;

        return inputVector;
    }

}
