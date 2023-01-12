using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    //variable para dar cuanto tiempo queremos que demore el player en aparecer 
    public float TiempowaitToRespawn;
    public int contadorMoneda;
    public int sumarpuntosenemigo;
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RespawnPlayer()
    {
        StartCoroutine(RespawnCo()); // llamamos una corutina creada mas abajo 
    }
    //LAS CORUTINAS NOS PERMITEN ESPERAR CIERTA CANTIDAD DE SEGUNDOS ANTES DE EJECUTAR UN CODIGO 
   //IENUMERATOR ES PARA DECLARAR LAS CORUTINAS
    IEnumerator RespawnCo()
    {
        acontrollervidaplayer.instance.gameObject.SetActive(false); //desactivamos al player cuando muere 
       // luego esperamos los segundos del spawn.
        yield return new WaitForSeconds(TiempowaitToRespawn);
        //pasado el tiempo revivimos al player
        acontrollervidaplayer.instance.gameObject.SetActive(true);
        //luego el player aparece en el ultimo checkpoint guardado que tocó cuando murió
        acontrollervidaplayer.instance.transform.position = checkpointController.instance.spawnPoint; //spawnpoint es donde guardamos esos datos del checkpoint
        //lo siguiente es para que cuando el player comience de nuevo aparezca con todas sus vidas
        acontrollervidaplayer.instance.vidaActual = acontrollervidaplayer.instance.vidaTotal;
        acontrollercanvas.instance.UpdateVida();
    }
}
