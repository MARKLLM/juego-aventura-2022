using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class otroNivel : MonoBehaviour   
{
    public bool cambioNivel;
    public int indiceNivel ;
    // funcion del menu para abrir el nivel 1
    public void escenajuego()
    {
        SceneManager.LoadScene("nivel_1");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            siguienteNivel(indiceNivel);
        }
        if (cambioNivel)
        {
            siguienteNivel(indiceNivel);
        }
    }

    public void siguienteNivel(int indice)
    {
        SceneManager.LoadScene(indice);
    }

   
    public void Salir()// funcion para cerrar el juego
    {
        Application.Quit();
        Debug.Log("esta saliendo");

    }
}

