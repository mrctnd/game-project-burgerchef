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

        // normalized = ayn� anda iki y�n tu�una bas�ld���nda e�it h�zlarda hareket etmesini sa�lar.
        inputVector = inputVector.normalized;

        return inputVector;
    }

}
