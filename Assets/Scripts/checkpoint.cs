using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public static checkpoint instance;
    public SpriteRenderer spriteR;//actuaizamos el spriterenderer
    public Sprite checkOn, checkOff;
    public GameObject sonido_checkP;

    private void Awake()
    {
        instance = this;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            checkpointController.instance.DesactivarCheckpoints();//instanciamos la funcion desactivarcheckpoint
         spriteR.sprite = checkOn;//con esto encendemos el checkpoint
            Instantiate(sonido_checkP);
        }checkpointController.instance.SetSpawnPoint(transform.position);//guardamos la posicion del ÚLTIMO  checkpoint que esta encendido 

    }
    public void ResetCheckpoint()//funcion que indica que debe resetear el checkpoint
    {
        spriteR.sprite = checkOff;//checkoff muestra el checkpoint desactivado
    }

}
