using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Damage : MonoBehaviour
{
    public Image healthBar;
    public static float health;


    public void TakeDamage (float amount)
    {
        //Debug.Log(healthBar);

        health -= amount;
        Debug.Log(health);

        healthBar.fillAmount = health / 100f;

    }
    

    // Start is called before the first frame update
    void Start()
    {

        health = 100f;
        Debug.Log(health);

    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = health / 100f;

        if (health <= 0)
        {
            Die();
        }
    }


    public void Die()
    {
        SceneManager.LoadScene("Death Screen");
    }


}
