using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float Xmin;
    public float Xmax;
    public float Ymin;
    public float Ymax;
    public Transform blanco; // acá indicamos donde va a estar enfocada la camara 
    // public Transform John;
    private void Start()
    {
        blanco = GameObject.Find("John").transform;
    }
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(blanco.position.x, Xmin, Xmax),
                                        Mathf.Clamp(blanco.position.y, Ymin, Ymax),
                                        transform.position.z);
       /* if (John != null)
        {
            Vector3 position = transform.position;
            position.x = John.position.x;
            transform.position = position;
        }*/
    }
}
