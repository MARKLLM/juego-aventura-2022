using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class extra : MonoBehaviour
{  
    public bool coin,vidaextra;
    private bool recolectado;
    public GameObject efecto_recolector;
    public GameObject sonidoMoneda;

    private void OnTriggerEnter2D(Collider2D other)
    {                                  //ayuda a evitar objetos duplicados
        if(other.CompareTag("Player")&& !recolectado)
        {
            if(coin)
            {
                LevelManager.instance.contadorMoneda++;//esto hace el conteo de las monedas
                acontrollercanvas.instance.contarMonedas();
                Instantiate(sonidoMoneda);
                Instantiate(efecto_recolector,transform.position,transform.rotation);
                recolectado=true;// si recolecto la moneda
            Destroy(gameObject);// se destruye el prefab moneda


            }
            if (vidaextra)
            { // decimos que si vidactual permite recibir vida osea que si controlador de vida no tiene vidatotal(completa)
                if (acontrollervidaplayer.instance.vidaActual != acontrollervidaplayer.instance.vidaTotal)
                {
                    acontrollervidaplayer.instance.DarVida();//llamamos a la funcion dar vida

                    recolectado = true;
                    AudioManager.instance.iniciarEfecSonid(7);
                    Destroy(gameObject);    
                }
            }
        }
    }
}
