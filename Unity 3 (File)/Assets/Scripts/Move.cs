using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float hInput;
    private float vInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //define the variables
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        //move the object
        transform.Translate(Vector3.right * hInput);
        transform.Translate(Vector3.forward * vInput);
    }
}
