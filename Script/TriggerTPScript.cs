using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTPScript : MonoBehaviour
{
    [SerializeField]
    private GameObject location;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Enemy")
        {
            other.transform.position = location.transform.position;
        }
    }
}
