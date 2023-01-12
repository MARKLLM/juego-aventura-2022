using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class acontrollercanvas : MonoBehaviour
{ public  static acontrollercanvas instance;

    public Image vida1, vida2, vida3;//referencia a los corazones de vida
    public Sprite vidaCompleta, vidaVacia, mediaVida;
    public Text monedaText;
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        contarMonedas();//cuando comience el juego saldrá 0 ya que no ha colisionado con ninguna moneda
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
