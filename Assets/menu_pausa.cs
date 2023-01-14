using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_pausa : MonoBehaviour
{
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject panelpausa;
        
    //public GameObject pantalla_pausa;
    //public bool pausado;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        
    }
    public void menupausado()
    {
        Time.timeScale = 0f;//detiene el juego
        botonPausa.SetActive(false);//desactivamos el boton de pausa al presionarlo
        panelpausa.SetActive(true);//activamos en panel de pausa

        /*if (pausado)
        {
           // pausado = false;
            //pantalla_pausa.SetActive(false);
            Time.timeScale = 0f; //1f indica que el tiempo es normal por lo tanto el juego sigue
        }
        else
        {
           // pausado = true;
           // pantalla_pausa.SetActive(true);
           // Time.timeScale = 0f;//esto detiene el juego 
        }*/
    }
    public void reanudar()
    {
        Time.timeScale = 1f;//1f indica que el tiempo es normal por lo tanto el juego sigue
        botonPausa.SetActive(true);//activamos el boton de pausa y volvemos al juego
        panelpausa.SetActive(false);//desactivamos en panel de pausa
    }


    public void menuprincipal()
    {
        SceneManager.LoadScene("menu_inicio");
        Time.timeScale = 1f;
    }

    public void cerrar()// funcion para cerrar el juego
    {
        Application.Quit();
        Debug.Log("esta saliendo");

    }

    public void volveraJugar()
    {
        SceneManager.LoadScene("nivel_1");
    }
}
