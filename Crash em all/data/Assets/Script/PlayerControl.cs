using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    private float turnSpeed = 45.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput * speed);
        transform.Rotate(Vector3.up, Time.deltaTime * horizontalInput * turnSpeed);

    }
}
