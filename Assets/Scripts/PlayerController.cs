using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float movementSpeed = 3f;
    void Update()
    {
        transform.position += Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
    }
}
