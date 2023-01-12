using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{ 
  public static AudioManager instance;
    public AudioSource[] efecto_sonido;

    private void Awake()
    {
     instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void iniciarEfecSonid(int iniciarSonido)
    {
        efecto_sonido[iniciarSonido].Play();
    }
}
