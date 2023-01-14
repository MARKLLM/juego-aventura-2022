using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointController : MonoBehaviour
{
    public static checkpointController instance;//lo declaramos static para ser usado en otros objetos
    public checkpoint[] checkpoints;
    public Vector3 spawnPoint; //variable para guardar la posicion del jugador y del checkpoint encendido 
                               //vector3 guarda las coordenadas de spawnpoint
 
    private void Awake()
    {
       instance = this;
    }


    void Start()
    {
        checkpoints=FindObjectsOfType<checkpoint>();//busca los checkpoint en la escena
        spawnPoint = acontrollervidaplayer.instance.transform.position;//aqui guardamos la posicion inicial de donde se encuentra el player
    
    }

    public void DesactivarCheckpoints()//funcion que itera por todos los check y cuando encuentre checkpoint indicado resetea todos los check
    {                   //i < checkpoints.Length para buscar lo checkpoint que hay en la matriz
        for (int i = 0; i < checkpoints.Length; i++)
        {
            checkpoints[i].ResetCheckpoint();
        }
    }
    // SPAWN POINT= PUNTO DE APARICIÓN
    public void SetSpawnPoint(Vector3 newSpawnPoint)
    { 
     spawnPoint = newSpawnPoint;    
    }
}
