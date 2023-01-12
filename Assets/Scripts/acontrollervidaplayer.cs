using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acontrollervidaplayer : MonoBehaviour
{
    public static acontrollervidaplayer instance;// los objetos se pueden llamar como instancia para que puedan ser llamados

    //en cualquier otro objeto (script)

    public GameObject muerte_player_efecto;
    private void Awake()
    {
        instance = this;
    }
    public int vidaActual, vidaTotal;
    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vidaTotal;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Daño()
    {
        vidaActual--;
        if (vidaActual <=0)
        {
            Instantiate(muerte_player_efecto,JohnMovement.instance.transform.position, JohnMovement.instance.transform.rotation);
           
            //Destroy(muerte_player_efecto);
            //Destroy(gameObject);
            // SceneManager.LoadScene(1);
            // gameObject.SetActive(false);
            //llamamos a player a que reviva en el ultimo checkpoint
            LevelManager.instance.RespawnPlayer();
        }
    }
    public void DarVida()
    {
        vidaActual++; //aquí damos la vida extra;

        if (vidaActual > vidaTotal)//para que no se entregen vidas demás decimos si vidaactual es mayor qeu vida total 
        {                        //vidaactual será igual que vidatotal
            vidaActual = vidaTotal;
        }
        acontrollercanvas.instance.UpdateVida();//actualizamos los corazones que se muestran en pantalla
    }
}
