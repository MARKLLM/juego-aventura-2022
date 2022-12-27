using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JohnMovement : MonoBehaviour
{
   // public AudioClip salto_sound;
    public float Speed;
    public float JumpForce;
    public GameObject BulletPrefab;

    private Rigidbody2D Rigidbody2D;
    private Animator Animator;
    private float Horizontal;
    private bool piso;
    private bool vacio;
    private float LastShoot;
    private int Health = 5;
    public GameObject sonidosalto;
    public GameObject sonidocaida;
    public bool Player;  //variable para caida
    public float Alturaperdiste;
    public bool Perdiste = false;
    public bool pasarNivel= false;
    public bool izq=false;
    public bool der=false;
    public CharacterController controller;





    private void Start()
    {
       
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
      //  salto_sound = GetComponent<AudioClip>();
    }

    private void Update()
    {
       
        if (der)
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
        }
        else if (izq)
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
        }
        // Movimiento
        Horizontal = Input.GetAxisRaw("Horizontal");//input es cuando presionamos una tecla

          //  if (Horizontal < 0.0f) transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
           // else if (Horizontal > 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

            Animator.SetBool("running", Horizontal != 0.0f);

            // Detectar Suelo
            // Debug.DrawRay(transform.position, Vector3.down * 0.1f, Color.red);
            if (Physics2D.Raycast(transform.position, Vector3.down, 0.1f))
            {
                piso = true;
            }
            else piso = false;

       
        // Salto
        /*  if (Input.GetKeyDown(KeyCode.W) && piso)
          {




          }*/


        // Disparar
        /*    if (Input.GetKey(KeyCode.Space) && Time.time > LastShoot + 0.25f)
            {
                Shoot();
                LastShoot = Time.time;
            }*/

        if (gameObject.transform.position.y < Alturaperdiste)
            // si la posicion del objeto (jugador) en la posicion y es menor a la variable alturaperdiste
        { 
         Perdiste = true;
            //si la sentencia de arriba ocurre dejamos estatico al personaje
            Rigidbody2D.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        
}

    private void FixedUpdate()
    {
       // Rigidbody2D.velocity = new Vector2(Horizontal * Speed, Rigidbody2D.velocity.y);
    }
    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.tag == "piso")
        {
            Player.Equals(true);
        }
        else { 
         piso = false;
        }
      
        //si 
        if (c.gameObject.tag == "meta")
        {
            Rigidbody2D.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }
    
    private void Saltar()
    {
        Rigidbody2D.AddForce(Vector2.up * JumpForce);
    }

    private void Shoot()
    {
        Vector3 direction;
        if (transform.localScale.x == 1.0f) direction = Vector3.right;
        else direction = Vector3.left;

        GameObject bullet = Instantiate(BulletPrefab, transform.position + direction * 0.1f, Quaternion.identity);
        bullet.GetComponent<BulletScript>().SetDirection(direction);
    }

    public void Hit()
    {
        Health -= 1;
        if (Health == 0)
        { 
         Destroy(gameObject);
         SceneManager.LoadScene(1);
        }
    }
    public void muerte()
    {
      
    }

    public void Izquierda()
    {
           izq = true;
        // der = false;
      // if (Horizontal < 0.0f) transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        /* if (izq == true)
         {
             controller.Move(Speed * Time.deltaTime * -transform.right);
         }*/
      //  Rigidbody2D.MovePosition(Vector2.left * Speed);
    }
    public void NOIzquierda()
    {
        izq = false;
    }
    public void Derecha()
    {  der = true;
      //izq= false;
       //if (Horizontal > 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        /* if (der == true)
         {
             controller.Move(transform.right * Speed * Time.deltaTime);
         }*/
        //Rigidbody2D.MovePosition(Vector2.right * Speed);
      
    }
    public void NODerecha()
    {
        der = false;
    }
    public void Arriba()
    {
        if (piso) { 
        Saltar();
        Instantiate(sonidosalto);
        }
    }
    public void disparo()
    {
        if (/*Input.GetKey(KeyCode.Space) */ Time.time > LastShoot + 0.25f)
        {
            Shoot();
            LastShoot = Time.time;
        }
    }
}