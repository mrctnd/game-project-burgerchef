using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{



    public Vector2 GetMovementVectorNormalized() 
    {
        Vector2 inputVector = new Vector2(0, 0);
        // KeyCodesi al�nan tu�a bas�l� tutuldu�u s�rece �al���r (GetKey)
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

        // normalized = ayn� anda iki y�n tu�una bas�ld���nda e�it h�zlarda hareket etmesini sa�lar.
        inputVector = inputVector.normalized;

        return inputVector;
    }

}
