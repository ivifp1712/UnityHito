using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Objeto target = collision.gameObject.GetComponent<Objeto>();
        if (target != null)
        {
            target.Hit(10);
            Destroy(gameObject);
        }
    }
}
