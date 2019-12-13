using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScriptWave : MonoBehaviour
{

    [SerializeField]
    private GameObject EnemyPrefabC;

    [SerializeField]
    private GameObject EnemyPrefabD;

    [SerializeField]
    private GameObject EnemyPrefabG;

    private float t = 0;

    void Update()
    {
        t += Time.deltaTime;
        if (t > 30)
        {
            GameObject g = RandomGameObject();
            g.transform.position = transform.position;
            t = 0;
        }
    }

    public GameObject RandomGameObject()
    {
        int rand = Random.Range(0, 2);
        if(rand == 0) return Instantiate(EnemyPrefabC);
        else if(rand == 1) return Instantiate(EnemyPrefabD);
        else return Instantiate(EnemyPrefabG);
    }


}
