using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCaCScript : MonoBehaviour
{

    [SerializeField]
    private int Damage;

    private float t = 0;

    private GameObject Arm1;

    // Start is called before the first frame update
    void Start()
    {
        Arm1 = GameObject.FindGameObjectWithTag("Arm1");
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 15 && (Arm1.transform.childCount == 0 || Arm1.transform.parent == null))
        {
            Destroy(gameObject);
        }
        if (Arm1.transform.childCount == 1) t = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Arm1.transform.childCount == 0)
            {
                this.transform.SetParent(Arm1.transform);
                // TODO
                // Change position and scale 
                // le modéliser sur player et get les pos et scale
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EnemyDistance" || collision.gameObject.tag == "EnemyCaC")
        {
            collision.gameObject.GetComponentInParent<LifeScript>().UpdateLife(-Damage);
        }
    }

}
