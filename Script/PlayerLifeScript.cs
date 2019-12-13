using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PlayerLifeScript : LifeScript
{
    public override void Death()
    {
        // GetComponentInChildren<Animator>().SetTrigger("Death");
        End();
    }

    public override void End()
    {
        Destroy(gameObject);
    }

    public override void UpdateLife(int nb)
    {
        base.UpdateLife(nb);
    }
}
