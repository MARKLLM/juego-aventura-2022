using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class acontrollercanvas : MonoBehaviour
{ public  static acontrollercanvas instance;

    public Image vida1, vida2, vida3;//referencia a los corazones de vida
    public Sprite vidaCompleta, vidaVacia, mediaVida;
    public Text monedaText;
    public GameObject nivelComplet;
   // public Image desvanecer_imagen;
   // public float desvanecer_velocidad;
 //   private bool pasarde0a1,pasarde1a0;//para la transparencia de la pantalla negra

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        contarMonedas();//cuando comience el juego saldrá 0 ya que no ha colisionado con ninguna moneda
       // desvanecerde1a0(); // llamamos a la funcion al iniciar el canvas para que se desvanezca de negro a blanco
    }

    // Update is called once per frame
    void Update()
    {
      /*  if (pasarde0a1)
        {//usamos los componentes de color para devanecer la imagen red,green,blue,
            desvanecer_imagen.color = new Color(desvanecer_imagen.color.r, desvanecer_imagen.color.g, desvanecer_imagen.color.b,Mathf.MoveTowards(desvanecer_imagen.color.a,1f,desvanecer_velocidad * Time.deltaTime));
            if (desvanecer_imagen.color.a ==1)
            {
                pasarde0a1 = false;//si ya es igual a uno se desactiva
            }
        }
        if (pasarde1a0)
        {//usamos los componentes de color para devanecer la imagen red,green,blue,
            desvanecer_imagen.color = new Color(desvanecer_imagen.color.r, desvanecer_imagen.color.g, desvanecer_imagen.color.b, Mathf.MoveTowards(desvanecer_imagen.color.a, 0f, desvanecer_velocidad * Time.deltaTime));
            if (desvanecer_imagen.color.a == 0)
            {
                pasarde1a0 = false;//si ya es igual a 0 se desactiva
            }
        }*/
    }
    public void UpdateVida()
    {
        switch (acontrollervidaplayer.instance.vidaActual)
        {
            case 6:
                vida1.sprite = vidaCompleta;
                vida2.sprite = vidaCompleta;
                vida3.sprite = vidaCompleta;
                break;
            case 5:
                vida1.sprite = vidaCompleta;
                vida2.sprite = vidaCompleta;
                vida3.sprite = mediaVida;
                break;
            case 4:
                vida1.sprite = vidaCompleta;
                vida2.sprite = vidaCompleta;
                vida3.sprite = vidaVacia;
                break;
            case 3:
                vida1.sprite = vidaCompleta;
                vida2.sprite = mediaVida;
                vida3.sprite = vidaVacia;
                break;
            case 2:
                vida1.sprite = vidaCompleta;
                vida2.sprite = vidaVacia;
                vida3.sprite = vidaVacia;
                break;
            case 1:
                vida1.sprite = mediaVida;
                vida2.sprite = vidaVacia;
                vida3.sprite = vidaVacia;
                break;

            case 0:
                vida1.sprite = vidaVacia;
                vida2.sprite = vidaVacia;
                vida3.sprite = vidaVacia;
                break;

            default:
                vida1.sprite = vidaVacia;
                vida2.sprite = vidaVacia;
                vida3.sprite = vidaVacia;
                break;
        }
    }

    public void contarMonedas()
    {
        monedaText.text = LevelManager.instance.contadorMoneda.ToString();

    }
   /* public void desvanecerde0a1()
    {
        pasarde0a1 = true;
        pasarde1a0 = false;
    }
    public void desvanecerde1a0()
    {
        pasarde0a1 = false;
        pasarde1a0 = true;
    }*/
}

