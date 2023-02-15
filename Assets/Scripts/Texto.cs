using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Texto : MonoBehaviour
{

    public TMP_Text texto;
    public int bolas = 10; 

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // cambiar texto
        texto.text = "Hola Mundo";

        if (bolas == 0)
        {
        texto.text = "Se acabo! :(";
        }
        else
        {
        texto.text = "Te quedan " + bolas + " bolas";
        }

    }

     public void Hit()
    {
        bolas = bolas - 1;
    }
}
