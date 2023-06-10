using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointScore : MonoBehaviour
{
    public Action OnObjDestroy;
    [SerializeField]
    private TextMeshProUGUI scoreText;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score;
        OnObjDestroy += IncScore;
    }

    public void IncScore()
    {
        score++;
        scoreText.text="Score: " + score;
    }
}
    

