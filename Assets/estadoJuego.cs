using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class estadoJuego : MonoBehaviour
{ public static estadoJuego EstadoJuego;
    public int maximoPuntaje=0;
    
    private void Awake() //sirve para inicializar el componente del objeto igual que el start
    { if (EstadoJuego == null)
        {
            EstadoJuego = this;
            DontDestroyOnLoad(gameObject);
           
        }
        else if(EstadoJuego !=this)
        {
           Destroy(gameObject);
        }
       
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void guardar()
    { 
    }
    void cargar()
    { 
    }
}
[Serializable]
class InfoGuardada {
    public int maximoPuntaje;
    public InfoGuardada(int maximoPuntaje)
    {
        this.maximoPuntaje = maximoPuntaje;
    }
}
