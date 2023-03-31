using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    public int maxHealth = 10;

    public int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        currentHealth = maxHealth;
    }

public void TakeDamage(int dagAmount)
{
    currentHealth -= dagAmount;
    Debug.Log("Player Health = "+ currentHealth);

    if(currentHealth <=0)
    {
        Debug.Log("You are dead! Game Over!");
        Time.timeScale = 0;
    }
}
    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddHealth(int healAmount)
    {
        currentHealth += healAmount;

        if(currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}
