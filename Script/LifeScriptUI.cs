using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeScriptUI : MonoBehaviour
{
    public int currentLife;
    public int oldLife;

    private GameObject Player;
    private LifeScript playerLifeScript;


    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        playerLifeScript = Player.GetComponent<LifeScript>();
        currentLife = playerLifeScript.CurrentLife;
        oldLife = currentLife;
        GetComponent<TMPro.TextMeshProUGUI>().text = "Life : " + currentLife;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentLife != oldLife)
        {
            oldLife = currentLife;
            GetComponent<TMPro.TextMeshProUGUI>().text = "Life : " + currentLife;
        }
    }
}
