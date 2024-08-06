using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{



    public Vector2 GetMovementVectorNormalized() 
    {
        Vector2 inputVector = new Vector2(0, 0);
        // KeyCodesi alýnan tuþa basýlý tutulduðu sürece çalýþýr (GetKey)
        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y = +1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x = +1;
        }

        // normalized = ayný anda iki yön tuþuna basýldýðýnda eþit hýzlarda hareket etmesini saðlar.
        inputVector = inputVector.normalized;

        return inputVector;
    }

}
