using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    [SerializeField]
    private Vector3 rotationVector;
    void Update()
    {
        transform.Rotate(rotationVector * Time.deltaTime);
    }
}
