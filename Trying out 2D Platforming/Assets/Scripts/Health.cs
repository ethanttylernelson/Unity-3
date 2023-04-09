using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{

    public int maxHealth = 10;

    public int currentHealth;

    public int numberOfHearts;

    public Image[] hearts;

    public Sprite bigHeart;

    public Sprite smallHeart;

    public int dagAmount = 1;
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
        if(currentHealth > numberOfHearts)
        {
            currentHealth = numberOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < currentHealth)
            {
                hearts[i].sprite = bigHeart;
            }
            else
            {
                hearts[i].sprite = smallHeart;
            }
            if(i < numberOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    public void AddHealth(int healAmount)
    {
        currentHealth += healAmount;

        if(currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        TakeDamage(dagAmount);
        Debug.Log("Player Takes "+ dagAmount + "points of damage!");
    }
}
