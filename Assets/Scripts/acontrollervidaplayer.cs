using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acontrollervidaplayer : MonoBehaviour
{
    public static acontrollervidaplayer instance;// los objetos se pueden llamar como instancia para que puedan ser llamados
    //en cualquier otro objeto (script)
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
            //Destroy(gameObject);
            // SceneManager.LoadScene(1);
            // gameObject.SetActive(false);
            //llamamos a player a que reviva en el ultimo checkpoint
            LevelManager.instance.RespawnPlayer();
        }
    }
}
