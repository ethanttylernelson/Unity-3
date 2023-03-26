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
       if (Input.GetKeyDown(KeyCode.Space))//(Input.GetButtonDown("Space"))
       {
        Shoot();
       } 
    }

    void Shoot()
    {
        Instantiate(projectile, firePoint.position, firePoint.rotation);
    }
}
