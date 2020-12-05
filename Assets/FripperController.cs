using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    private HingeJoint myHingeJoint;

    private float defaultAngle = 20;

    private float flickAngle = -20;

    void Start ()
	{
        this.myHingeJoint = GetComponent<HingeJoint>();

        SetAngle(this.defaultAngle);
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag")
		{
            SetAngle(this.flickAngle);
		}
        if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        if (Input.GetKeyDown(KeyCode.A) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        if (Input.GetKeyUp(KeyCode.A) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }



        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag")
		{
            SetAngle(this.flickAngle);
		}
        if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        if (Input.GetKeyDown(KeyCode.D) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        if (Input.GetKeyUp(KeyCode.D) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }



        if (Input.GetKeyDown(KeyCode.DownArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }



        if (Input.GetKeyDown(KeyCode.S) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        if (Input.GetKeyUp(KeyCode.S) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        if (Input.GetKeyDown(KeyCode.S) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        if (Input.GetKeyUp(KeyCode.S) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

    }

    public void SetAngle (float angle)
	{
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
	}
}
