using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("Score");
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }


    //scoreTextを定義
    private GameObject scoreText;

    private int scoreNumber = 0;

    void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.tag);

        if (other.gameObject.tag == "SmallStarTag")
        {
            this.scoreNumber += 10;
            string scoreString = this.scoreNumber.ToString();
            this.scoreText.GetComponent<Text>().text = scoreString;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            this.scoreNumber += 20;
            string scoreString = this.scoreNumber.ToString();
            this.scoreText.GetComponent<Text>().text = scoreString;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            this.scoreNumber += 30;
            string scoreString = this.scoreNumber.ToString();
            this.scoreText.GetComponent<Text>().text = scoreString;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            this.scoreNumber += 40;
            string scoreString = this.scoreNumber.ToString();
            this.scoreText.GetComponent<Text>().text = scoreString;
        }
    }
}

