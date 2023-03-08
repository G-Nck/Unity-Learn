using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed;
    public float horizontalInput;

    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

    }
}
