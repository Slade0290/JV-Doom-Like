using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnnemyLifeScript : LifeScript
{
    [SerializeField]
    public Image LifeBar;

    private ScoreScript scoreScript;
    private GameObject Score;

    private void Start()
    {
        MaxLife = CurrentLife;
        Score = GameObject.FindGameObjectWithTag("Score");
        scoreScript = Score.GetComponent<ScoreScript>();
    }


    public override void Death()
    {
        //GetComponentInChildren<Animator>().SetTrigger("Death");
        GetComponent<NavMeshAgent>().speed = 0;
        End();
    }

    public override void End()
    {
        scoreScript.Score++;  
        Destroy(gameObject);
    }

    public override void UpdateLife(int nb)
    {
        base.UpdateLife(nb);
        if (CurrentLife > 0)
        {
            LifeBar.transform.localScale = new Vector3(((float)CurrentLife / (float)MaxLife), 1, 1);
        }
        else
        {
            LifeBar.transform.localScale = new Vector3(0, 1, 1);
        }
    }
}
