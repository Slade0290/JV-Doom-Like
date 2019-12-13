using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    [SerializeField]
    private GameObject PrefabBullet;

    [SerializeField]
    private Transform[] StartPosBullets;

    [SerializeField]
    private float ShootPower;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject Arm1 = GameObject.FindGameObjectWithTag("Arm1");
            if (Arm1.transform.childCount == 1) {
                if (Arm1.transform.GetChild(0).name == "Bit Gun(Clone)")
                {
                    GameObject bullet = Instantiate(PrefabBullet);
                    bullet.transform.position = StartPosBullets[0].position;
                    bullet.GetComponent<Rigidbody>().AddForce(StartPosBullets[0].forward * ShootPower);
                }
            }
        }
    }
}
