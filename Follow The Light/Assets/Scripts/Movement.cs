using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
public float moveSpeed;


void Update()
{
    Vector3 velocity = new Vector3(Input.GetAxis("Horizontal"), 0);
}
}
