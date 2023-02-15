using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto : MonoBehaviour
{

    public int health = 10;

    private void Start()
    {
        
    }
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Objeto destruido");
            // obetenr texto
            Texto texto = GameObject.Find("Texto").GetComponent<Texto>();
            texto.Hit();
        }

    }

    public void Hit(int damage)
    {
        health -= damage;
        
    }
}
