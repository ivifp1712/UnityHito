using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimient : MonoBehaviour
{
    public float velocidadMovimiento = 5f;
    public float velocidadRotacion = 100f;
    private Animator anim;
    public float x,y;


    public float force = 150;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // float h = Input.GetAxis("Horizontal");


        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * velocidadRotacion * Time.deltaTime, 0);
        transform.Translate(0, 0, y * velocidadMovimiento * Time.deltaTime);

    }
}
