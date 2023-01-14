using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// para que habilite las opciones de interfaz de usuario del canvas

public class volumScript : MonoBehaviour
{// definicion de variables
    public Slider slider;
    public float valor_slider;
    public Image imagemute;

    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volumenAudio", 0.5f);//creamos un valor que nos permite guardar la posicion del slider 
        //el valor 0.5f indica que el volumen este predeterminado a la mitad 
        AudioListener.volume = slider.value;// AudioListener.volume con esto obtenemos el volumen del juego
                                            // volume.value nos da el valor que posee el volumen actual
        Silenciado();//llamamos a la funcion 

    }
    public void ChangeSlider(float valor)
    {
        valor_slider = valor;
        PlayerPrefs.SetFloat("volumenAudio", valor_slider);//aqui le otorgamos un valor de volumen, el cual sería  lo que esta en valor_slider
        AudioListener.volume = slider.value;
        Silenciado(); //llamamos a la funcion

    }
    public void Silenciado()//esta funcion sirve para revisar si el volumen se encuentra en 0 o no 
    {
        if (valor_slider == 0)
        {
            imagemute.enabled = true;//activamos una imagen que muestre que el volumen esta en 0 
        }
        else
        {
            imagemute.enabled = false;
        }
    }


}
