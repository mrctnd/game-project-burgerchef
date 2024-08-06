using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // SerializeField private olarak tan�mlanan nesneyi ayn� zamanda editorde g�z�kmesini sa�lar.
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private GameInput gameInput;

    private bool isWalking;

    private void Update()
    {
        Vector2 inputVector = gameInput.GetMovementVectorNormalized();
        // karakterin pozisyon hareketini 3 boyutta tan�mlama.
        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);

        // Her bir frame de karakterin pozisyonunu g�nceller.
        transform.position += moveDir * moveSpeed * Time.deltaTime;

        isWalking = moveDir != Vector3.zero;
        float rotateSpeed = 10f;
        transform.forward = Vector3.Slerp(transform.forward, moveDir, Time.deltaTime * rotateSpeed);
        Debug.Log(inputVector);
    }

    public bool IsWalking() {
        return isWalking;
    }
}
