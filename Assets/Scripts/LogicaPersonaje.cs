using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPersonaje : MonoBehaviour
{
    public float velocidadMovimiento = 5f;
    public float velocidadRotacion = 100f;
    private Animator anim;
    public float x,y;

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    float yaw = 0.0f;
    float pitch = 0.0f;

    // Disparar
    public GameObject BalaInicio;
    public GameObject BalaPrefab;
    public float BalaVelocidad;
    public float force = 150;

    public float timeBetweenShots = 0.5f;
    private float timeSinceLastShot;


    void Start()
    {
        anim = GetComponent<Animator>();
        timeSinceLastShot = timeBetweenShots;

    }

    void Update()
    {

        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Translate(0, 0, y * velocidadMovimiento * Time.deltaTime);
        transform.Translate(x * velocidadMovimiento * Time.deltaTime, 0, 0);

        // transform.Translate(0, x * velocidadRotacion * Time.deltaTime, 0);
        // transform.Translate(0, 0, y * velocidadMovimiento * Time.deltaTime);

        // Mover personaje arriba, abajo, derecha, izquierda


        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("correr", true);
        }
        else
        {
            anim.SetBool("correr", false);
        }

        if(Input.GetButton("Fire1")){
            if(timeSinceLastShot >= timeBetweenShots){
                    //1-Instanciar la BalaPrefab en las posiciones de BalaInicio
                    GameObject BalaTemporal = Instantiate(BalaPrefab, BalaInicio.transform.position, BalaInicio.transform.rotation) as GameObject;
        
                    //Obtener Rigidbody para agregar Fuerza. 
                    Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
            
                    //Agregar la fuerza a la Bala
                    rb.AddForce(transform.forward * BalaVelocidad);
        
                    //Debemos Destruir la bala
                    Destroy(BalaTemporal, 5.0f);
                    //bulletObject.transform.position = transform.position + transform.forward;
                    timeSinceLastShot = 0f;
            }
        }
        timeSinceLastShot += Time.deltaTime;
        

    }
}
