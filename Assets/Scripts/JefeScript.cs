using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JefeScript : MonoBehaviour
{
    public GameObject John;
    public GameObject BulletPrefab;
    private int Health = 5;
    private float LastShoot;
    public GameObject efect_muerte_enemy;
    private void Shoot()
    {
        Debug.Log("disparo");
       /* Vector3 direction = new Vector3(transform.localScale.x, 0.0f, 0.0f);
        GameObject bullet = Instantiate(BulletPrefab, transform.position + direction * 0.1f, Quaternion.identity);
        bullet.GetComponent<BulletScript>().SetDirection(direction);*/
    }

    // Update is called once per frame
    void Update()
    {
        if (John == null) return;

        Vector3 direction = John.transform.position - transform.position;
        if (direction.x >= 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        else transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);

        float distance = Mathf.Abs(John.transform.position.x - transform.position.x);

        if (distance < 1.0f && Time.time > LastShoot + 0.25f)
        {
            Shoot();
            LastShoot = Time.time;
        }
    }
    public void Hit()
    {
        Health -= 1;
        if (Health == 0)
        {
            Destroy(gameObject);


            Instantiate(efect_muerte_enemy, GruntScript.instance.transform.position, GruntScript.instance.transform.rotation);

        }
    
    }
}
