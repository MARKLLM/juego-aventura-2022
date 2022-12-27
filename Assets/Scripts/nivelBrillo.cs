using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// nos permite usar todos los 


public class nivelBrillo : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public Image panelBrillo;
    void Start()
    {// almacena el último valor de brillo quedó guarado o inicia con con un nivel predefinido con 0.5f
        // acá decimos que el color principal es igual a lo que está almacenado
        slider.value = PlayerPrefs.GetFloat("brillo", 0.5f);

        //acá obtenemos el color principal de nuestro panel e ir cambiandolo 
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, slider.value);
        //r=red...g==green...b==blue
    }

    public void ChangeSlider(float valor)
    {
        sliderValue = valor;
        //aqui guardamos el valor nuevo al mover el slider
        PlayerPrefs.SetFloat("brillo", sliderValue);
        // al mover el slider va cambiando el valor principal 
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, slider.value);

    }
}
