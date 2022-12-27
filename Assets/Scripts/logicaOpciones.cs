using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicaOpciones : MonoBehaviour
{
    public ControlOpcion panelOpciones;//creamos la variable que llama al panel de opciones

    void Start()
    {
      //  panelOpciones = GameObject.FindGameObjectWithTag("opciones").GetComponent<ControlOpcion>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MostrarOpciones();
        }
    }
    public void MostrarOpciones()
    { 
     panelOpciones.pantallaOpciones.SetActive(true);    
    }
}
