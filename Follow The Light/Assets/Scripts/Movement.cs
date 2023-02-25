using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Transform trasnform;

    public Vector3 posVec3;
    public Vector3 rotateVec3;
    public Vector3 scaleVec3;
    // Start is called before the first frame update
    void Start()
    {
        posVec3 = new Vector3(.0001f,.0001f,.0001f);
        rotateVec3 = new Vector3(.0f, 0f, .01f);
        scaleVec3 = new Vector3(.0001f, .0001f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += posVec3;
        transform.Rotate(rotateVec3);
        trasnform.localScale += scaleVec3;
    }
}
