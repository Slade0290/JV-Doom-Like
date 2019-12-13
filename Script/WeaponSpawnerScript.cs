using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawnerScript : MonoBehaviour
{

    [SerializeField]
    private GameObject WeaponDistance;

    [SerializeField]
    private GameObject WeaponCaC;

    private float t = 0;
    private GameObject Arm1;

    void Start()
    {
        Arm1 = GameObject.FindGameObjectWithTag("Arm1");
        GameObject g = RandomGameObject();
        g.transform.position = transform.position;
    }

    void Update()
    {
        t += Time.deltaTime;
        int rand = Random.Range(0, 100);
        if (t > 30 && rand % 2 == 0 && Arm1.transform.childCount == 0)
        {
            GameObject g = RandomGameObject();
            g.transform.position = transform.position;
            t = 0;
        }
    }
    
    public GameObject RandomGameObject()
    {
        int rand = Random.Range(0, 2);
        if (rand == 0) return Instantiate(WeaponDistance);
        else return Instantiate(WeaponCaC);
    }

}
