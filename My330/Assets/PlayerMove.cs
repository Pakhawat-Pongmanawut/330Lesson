using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 4.0f;

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // Using "A" and "D" keys

        Vector3 movement = new Vector3(horizontalInput, 0, 0) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);
    }
}
 
