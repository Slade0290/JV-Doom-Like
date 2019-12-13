using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnnemisScript : MonoBehaviour
{
    //public GameObject PrefabExplosion;

    private GameObject Target;

    [SerializeField]
    private GameObject PrefabBullet;

    [SerializeField]
    private Transform[] StartPosBullets;

    [SerializeField]
    private float ShootPower;

    private float t;

    [SerializeField]
    private int Damage;

    private void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player");
        GetComponent<NavMeshAgent>().SetDestination(Target.transform.position); 
    }

    private void Update()
    {
        t += Time.deltaTime;
        if (GetComponent<NavMeshAgent>().remainingDistance < 5 && t > 1)
        {
            if (gameObject.tag == "EnemyDistance")
            {
                // Distance
                GameObject bullet = Instantiate(PrefabBullet);
                bullet.transform.position = StartPosBullets[0].position;
                bullet.GetComponent<Rigidbody>().AddForce(StartPosBullets[0].forward * ShootPower);
                //GetComponent<NavMeshAgent>().isStopped = true;
            } 
            t = 0;
        }
        else
        {
            //GetComponent<NavMeshAgent>().isStopped = false;
            GetComponent<NavMeshAgent>().SetDestination(Target.transform.position);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // CaC
            collision.gameObject.GetComponentInParent<LifeScript>().UpdateLife(-Damage);
            LifeScript playerLifeScript = collision.gameObject.GetComponent<LifeScript>();
            GameObject Life = GameObject.FindGameObjectWithTag("Life");
            LifeScriptUI LifeScript = Life.GetComponent<LifeScriptUI>();
            LifeScript.currentLife = playerLifeScript.CurrentLife;
        }
    }
}
