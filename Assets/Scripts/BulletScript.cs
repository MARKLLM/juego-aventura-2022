using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{ public static BulletScript instance;
    public float Speed;
    public AudioClip Sound;

    private Rigidbody2D Rigidbody2D;
    private Vector3 Direction;

    private void Awake()
    {
        instance = this; 
    }
    private void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Camera.main.GetComponent<AudioSource>().PlayOneShot(Sound);
    }

    private void FixedUpdate()
    {
        Rigidbody2D.velocity = Direction * Speed;
    }

    public void SetDirection(Vector3 direction)
    {
        Direction = direction;
    }

    public void DestroyBullet()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       GruntScript grunt = other.GetComponent<GruntScript>();
        JefeScript jefe = other.GetComponent<JefeScript>();
        //  acontrollervidaplayer john = other.GetComponent<acontrollervidaplayer>();
        if (grunt != null)
        {
            grunt.Hit();
           // Instantiate(GruntScript.instance.efect_muerte_enemy, GruntScript.instance.transform.position, GruntScript.instance.transform.rotation);

        }

      
        if (other.tag == "Player")
        {
            acontrollervidaplayer.instance.Daño();
        }
        acontrollercanvas.instance.UpdateVida();
        DestroyBullet();

        if (jefe != null)
        {
            jefe.Hit();
            // Instantiate(GruntScript.instance.efect_muerte_enemy, GruntScript.instance.transform.position, GruntScript.instance.transform.rotation);

        }
    }
}
