using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealTriggerZoneScript : MonoBehaviour
{   
    private LifeScript playerLifeScript;

    private GameObject LifeScript;
    private LifeScriptUI lifeScriptUI;

    private float t;

    private void Start()
    {

        LifeScript = GameObject.FindGameObjectWithTag("Life");
        lifeScriptUI = LifeScript.GetComponent<LifeScriptUI>();
    }
    private void OnTriggerStay(Collider other)
    {
        t += Time.deltaTime;

        if (other.gameObject.tag == "Player" && t > 15)
        {
            playerLifeScript = other.GetComponent<LifeScript>();
            playerLifeScript.UpdateLife(1);
            lifeScriptUI.currentLife += 1;
            t = 0;
        }
    }
}
