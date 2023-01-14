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
           // StartCoroutine(corutinaNivelnuevo());
           // acontrollercanvas.instance.nivelComplet.SetActive(true);
         
         
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

    
  /*  public  IEnumerator corutinaNivelnuevo()
    {
        yield return new WaitForSeconds(5f);
        acontrollercanvas.instance.nivelComplet.SetActive(true);

       // yield return new WaitForSeconds(5f);
        siguienteNivel(indiceNivel);
    }*/
}

