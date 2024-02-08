using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Health;
    private int currentHealth;

    public void TakeDamage(int damage)
    {
        currentHealth = Health -= damage;
        GetComponent<Animator>().SetTrigger("Hurt");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        GetComponent<Animator>().SetTrigger("Death");

        GetComponent<Collider2D>().enabled = false;

        this.enabled = false;
    }
}