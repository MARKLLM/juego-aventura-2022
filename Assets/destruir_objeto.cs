using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruir_objeto : MonoBehaviour
{
    public float lifeTime;

    // Update is called once per frame
    void Update()
    {
       Destroy(gameObject,lifeTime);
    }
}
