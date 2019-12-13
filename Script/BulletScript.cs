using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    [SerializeField]
    private int Damage;       
    [SerializeField]    
    private float Lifetime;

    void Start()
    {
        Destroy(gameObject, Lifetime);       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EnemyDistance" || collision.gameObject.tag == "EnemyCaC" || collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponentInParent<LifeScript>().UpdateLife(-Damage);
            if(collision.gameObject.tag == "Player")
            {
                LifeScript playerLifeScript = collision.gameObject.GetComponent<LifeScript>();
                GameObject Life = GameObject.FindGameObjectWithTag("Life");
                LifeScriptUI LifeScript = Life.GetComponent<LifeScriptUI>();
                LifeScript.currentLife = playerLifeScript.CurrentLife;
            }
        }
        Destroy(gameObject);

    }
}
