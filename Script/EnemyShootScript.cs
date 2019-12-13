using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyShootScript : MonoBehaviour
{

    [SerializeField]
    private GameObject PrefabBullet;

    [SerializeField]
    private Transform[] StartPosBullets;

    [SerializeField]
    private float ShootPower;

    void Update()
    {
        //GameObject Player = GameObject.FindGameObjectWithTag("Player");
        //if (Player.GetComponent<NavMeshAgent>().remainingDistance < 1)
        //{
        //    GameObject bullet = Instantiate(PrefabBullet);
        //    bullet.transform.position = StartPosBullets[0].position;
        //    bullet.GetComponent<Rigidbody>().AddForce(StartPosBullets[0].forward * ShootPower);
        //}
    }
}
