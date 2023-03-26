using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWeapon : MonoBehaviour
{
 public Transform leftPoint;
    public GameObject leftProjectile;
    // Start is called before the first frame update


    void Update()
    {
        if(Input.GetKey(KeyCode.D))
       {
        ShootLeft();
       } 
    }

    void ShootLeft()
    {
        Instantiate(leftProjectile, leftPoint.position, leftPoint.rotation);
       //if (playerController.isFacingRight == false)
           // {
            //    Instantiate(projectile, leftPoint.position, leftPoint.rotation);
           // }
        }
}
