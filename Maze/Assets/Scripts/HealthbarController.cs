using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HealthbarController : MonoBehaviour

{
    public Image healthBar;
    public float health;
    public float startHealth;

    public void OnTakeDamage(int damage)

    {
        if (health < damage)
        {
            KeyCounter.instance.ResetKey();
            SceneManager.LoadScene(4);
        }
        health = health - damage;
        healthBar.fillAmount = health / startHealth;
    }
}