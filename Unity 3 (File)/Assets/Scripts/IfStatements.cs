using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    int time = 304;
    string weather = "clear";
    bool isRed = true;
    float gpa = 3.25f;
    double temperature = 101.45d;
    // Start is called before the first frame update
    void Start()
    {
        if(time >= 200) {
            Debug.Log("Wake up");
        }
    else {
        Debug.Log("Time for sleep");
    }
    if(weather == "thunder"){
        Debug.Log("Grab an unbrella!");
    }
    else if (weather == "raining"){
        Debug.Log("It's raining outside!");
    }
    else if (weather == "clear"){
        Debug.Log("What a beautiful day it is");
    }
    else if (weather == "Stormy"){
        Debug.Log("Stay indoors");
    }
else {
    Debug.Log("Do whatever you want");

}
    // Update is called once per frame
    void Update()
    {
        
    }
}
}