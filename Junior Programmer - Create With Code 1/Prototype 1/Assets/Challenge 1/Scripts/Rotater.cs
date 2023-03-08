using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    [SerializeField]
    Vector3 euler;
    [SerializeField]
    float rpm;
    private float Speed => rpm * 360;


    void Update()
    {
        float rotateAmount = Speed * Time.deltaTime;
        transform.Rotate(euler * rotateAmount);
    }
}
