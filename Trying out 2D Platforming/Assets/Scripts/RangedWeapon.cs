using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedWeapon : MonoBehaviour
{

    public Transform firePoint;
    public GameObject projectile;
    // Start is called before the first frame update
    void Update()
    {
        if(Input.GetKey(KeyCode.F))
       {
        Shoot();
       } 
    }

    void Shoot()
    {
        Instantiate(projectile, firePoint.position, firePoint.rotation);
        //if (playerController.isFacingRight == false)
           // {
            //    Instantiate(projectile, leftPoint.position, leftPoint.rotation);
           // }
        }

    
}
