using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
public float scaleToIncrease = 0.1f;

    public int clickToPop = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

void OnMouseDown()
{
clickToPop --;

transform.localScale += Vector3.one * scaleToIncrease;

if (clickToPop == 0)
{
    Destroy(gameObject);
}


}

}
