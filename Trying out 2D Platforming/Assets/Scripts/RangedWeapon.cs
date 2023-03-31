using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedWeapon : MonoBehaviour
{

    public Transform firePoint;
    public GameObject projectile;
    public PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
       {
        Shoot();
       } 
    }

    void Shoot()
    {
      Instantiate(projectile, firePoint.position, firePoint.rotation);
   
    }
}
