using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    float rotationSpeed;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        float translateAmount = speed * Time.fixedDeltaTime;
        transform.Translate(Vector3.forward * translateAmount);

        // tilt the plane up/down based on up/down arrow keys
        float rotationAmount = rotationSpeed * Time.fixedDeltaTime * verticalInput;
        transform.Rotate(Vector3.right * rotationAmount);
    }


}
