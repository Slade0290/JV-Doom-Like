using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public int Score;
    public int OldScore;

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        OldScore = 0;
        GetComponent<TMPro.TextMeshProUGUI>().text = "Score : " + Score;
    }

    // Update is called once per frame
    void Update()
    {
        if (Score != OldScore)
        {
            OldScore = Score;
            GetComponent<TMPro.TextMeshProUGUI>().text = "Score : " + Score;
        }
    }
}
