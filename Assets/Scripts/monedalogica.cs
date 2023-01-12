using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class monedalogica : MonoBehaviour
{ public static monedalogica instance;
    public GameObject sonidoMoneda;

    private void Awake()
    {
        instance = this; 
    }
    // public AudioSource sonido;
    // public int puntaje;
    //   public Text  puntajeText;   // Start is called before the first frame update
    void Start()
    {
      //  puntaje = 0;
    }
    public void OnTriggerEnter2D(Collider2D collider)//ontriggerenter2d se usa cuando un objeto entra en un collider
    {/*
        if (collider.tag == "Player") //si player choca con el objeto moneda , este ultimo se destruye
        {
            Instantiate(sonidoMoneda); //instancia al sonido
            Destroy(gameObject); 
          
        }*/
       /* if (collider.tag == "moneda")
        { 
         puntaje++;
            puntajeText.text = "Puntaje : " + puntaje;
        }*/
    }
}
