using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GruntScript : MonoBehaviour
{  public static GruntScript instance;  
    public Transform John;
    public GameObject BulletPrefab;
    public GameObject efect_muerte_enemy;
   // public AudioClip efect_muerte;
        
    //public float cambioCoins;
   // public GameObject recogerCoins;

    private int Health = 3;
    private float LastShoot;
    private void Awake()
    {
        instance = this;
    }
    void Update()
    {
        if (John == null) return;

        Vector3 direction = John.position - transform.position;
        if (direction.x >= 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        else transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);

        float distance = Mathf.Abs(John.position.x - transform.position.x);

        if (distance < 1.0f && Time.time > LastShoot + 0.25f)
        {
            Shoot();
            LastShoot = Time.time;
        }
    }

    private void Shoot()
    {
        Vector3 direction = new Vector3(transform.localScale.x, 0.0f, 0.0f);
        GameObject bullet = Instantiate(BulletPrefab, transform.position + direction * 0.1f, Quaternion.identity);
        bullet.GetComponent<BulletScript>().SetDirection(direction);
    }

    public void Hit()
    {
        Health -= 1;
        if (Health == 0)
        {
            Destroy(gameObject);
           
            
            Instantiate(efect_muerte_enemy, GruntScript.instance.transform.position, GruntScript.instance.transform.rotation);

        }
       /* float dropSelect = Random.Range(0, 100f);
        if (dropSelect <= cambioCoins)
        {
           
           
            Instantiate(recogerCoins, GruntScript.instance.transform.position, GruntScript.instance.transform.rotation);
        }*/
        

    }
}
