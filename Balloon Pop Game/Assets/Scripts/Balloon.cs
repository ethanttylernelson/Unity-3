using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int clickToPop = 3;//How many clicks to pop
    public float scaleToIncrease = 0.1f; //Increase in size per click

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
  void OnMouseDown(){
    
    clickToPop --; //clicks left to pop goes down by 1
    
    
    //Balloon inflates
    transform.localScale += Vector3.one * scaleToIncrease;
    

    //Check to see if clickToPop is at 0
    if (clickToPop == 0){
            Destroy(gameObject);
    }
  }
}
