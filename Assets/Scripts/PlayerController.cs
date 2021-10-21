using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime;
    }
}
