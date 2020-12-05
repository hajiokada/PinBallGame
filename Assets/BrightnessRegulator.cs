using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrightnessRegulator : MonoBehaviour
{
    Material myMaterial;

    //Emissionの最小値
    private float minEmission = 0.3f;

    //Emissionの強度
    private float magEmission = 2.0f;

    //角度
    private int degree = 0;

    //発光速度
    private int speed = 10;

    Color defaultColor = Color.white;

    // Start is called before the first frame update
    void Start()
    {
        if (tag == "SmallStarTag")
        {
            this.defaultColor = Color.white;
        }
        else if (tag == "SmallCloudTag" || tag == "LargeCloudTag")
        {
            this.defaultColor = Color.cyan;
        }

        this.myMaterial = GetComponent<Renderer>().material;

        //オブジェクトの最初の色を設定
        myMaterial.SetColor("_EmissionColor", this.defaultColor * minEmission);
        //Materialクラスの「SetColor」関数は、マテリアルの色を設定します。
        //第一引数に変更したい色のパラメータを指定し、第二引数に変更する色の値を指定します。

    }

    // Update is called once per frame
    void Update()
    {
        if (this.degree >= 0)
        {
            Color emissionColor = this.defaultColor * (this.minEmission + Mathf.Sin(this.degree * Mathf.Deg2Rad) * this.magEmission);

            myMaterial.SetColor("_EmissionColor", emissionColor);

            this.degree -= this.speed;
        }
    }

    // 「OnCollisionEnter」は、自分のColliderが他のオブジェクトのColliderと接触した時に呼ばれる関数です。
    void OnCollisionEnter(Collision other)
    {
        this.degree = 180;
    }
}