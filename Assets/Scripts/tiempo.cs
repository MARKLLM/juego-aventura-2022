using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiempo : MonoBehaviour
{
    public float tiempo_vida;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,tiempo_vida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
