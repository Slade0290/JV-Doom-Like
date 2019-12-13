using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float Speed = 25;
    [SerializeField]
    private float RotationSpeed = 250;

    [SerializeField]
    [Range(0, 500)]
    private float JumpForce = 10;

    private int NbColliderInTrigger = 0;

    //[SerializeField]
    //private GameObject PrefabBullet;

    //[SerializeField]
    //private Transform[] StartPosBullets;

    //[SerializeField]
    //private float ShootPower;

    void Update()
    {
        float DeltaSpeed = Speed * Time.deltaTime;
        float DelatRot = RotationSpeed * Time.deltaTime;

        int AxeZ = 0;
        int AxeX = 0;
        if (Input.GetKey(KeyCode.Z))
            AxeZ = 1;
        if (Input.GetKey(KeyCode.S))
            AxeZ = -1;
        if (Input.GetKey(KeyCode.Q))
            AxeX = -1;
        if (Input.GetKey(KeyCode.D))
            AxeX = 1;


        Vector3 CurrentSpeed = GetComponent<Rigidbody>().velocity;

        Vector3 MaxSpeedZ = AxeZ * Speed * transform.forward;
        Vector3 MaxSpeedX = AxeX * Speed * transform.right;

        GetComponent<Rigidbody>().AddForce(MaxSpeedZ - CurrentSpeed);
        GetComponent<Rigidbody>().AddForce(MaxSpeedX - CurrentSpeed);

        float Xaxis = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0, Xaxis * DelatRot, 0));


        if (Input.GetKeyDown(KeyCode.Space) && NbColliderInTrigger > 0)
            GetComponent<Rigidbody>().AddForce(new Vector3(0, JumpForce, 0));

        // Weapon section
        GameObject Arm1 = GameObject.FindGameObjectWithTag("Arm1");
        if (Input.GetKey(KeyCode.F))
        {
            if (Arm1.transform.childCount == 1)
            {
                Transform Weapon = Arm1.transform.GetChild(0);
                Weapon.SetParent(null);
                Weapon.position = Weapon.position + new Vector3(0, 0, 1);
            }
        }
        //if (Input.GetMouseButtonDown(0))
        //{
        //    if (Arm1.transform.childCount == 1)
        //    {
        //        GameObject bullet = Instantiate(PrefabBullet);
        //        bullet.transform.position = StartPosBullets[0].position;
        //        bullet.GetComponent<Rigidbody>().AddForce(StartPosBullets[0].forward * ShootPower);
        //    }
        //}

    }

    private void OnTriggerEnter(Collider other)
    {
        NbColliderInTrigger++;
    }

    private void OnTriggerExit(Collider other)
    {
        NbColliderInTrigger--;
    }
}
