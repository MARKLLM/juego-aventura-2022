using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaMuerte : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {//FUNCION PARA QUE REVIVE AL PERSONAJE SI ESTE TOCA EL COLLIDER DEL PISO VACÍO
        if (other.tag == "Player")
        {

            LevelManager.instance.RespawnPlayer();
        }
    }
}
