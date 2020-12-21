using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //scoreTextを定義
    private GameObject scoreText;

    static int scoreAdded = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision other)
    {


        if (tag == "SmallStarTag")
        {
            scoreAdded += 10;
        }
        else if (tag == "LargeStarTag")
        {
            scoreAdded += 20;
        }
        else if (tag == "SmallCloudTag")
        {
            scoreAdded += 30;
        }
        else if (tag == "LargeCloudTag")
        {
            scoreAdded += 40;
        }



        int scoreNumber = 0;
        scoreNumber += scoreAdded;
        string scoreString = Convert.ToString(scoreNumber);
        this.scoreText = GameObject.Find("Score");
        this.scoreText.GetComponent<Text>().text = scoreString;

    }
}