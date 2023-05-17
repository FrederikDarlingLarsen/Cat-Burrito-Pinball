using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject rightFlipper;
    public GameObject leftFlipper;
    HingeJoint leftHingeJoint;
    HingeJoint rightHingeJoint;
    Rigidbody ballRigidbody;

    void Start()
    {
      leftHingeJoint = leftFlipper.GetComponent<HingeJoint>();
      rightHingeJoint = rightFlipper.GetComponent<HingeJoint>();
      leftHingeJoint.useSpring = true;
      rightHingeJoint.useSpring = true;
    }

    void Update()
    {
        JointSpring leftSpring = new JointSpring();
        leftSpring.spring = 30000.0f;
        leftSpring.damper = 10.0f;

         if(Input.GetKey(KeyCode.Q)){
           leftSpring.targetPosition = -60.0f;
         }
         if(Input.GetKeyUp(KeyCode.Q)){
           leftSpring.targetPosition = 0.0f;
         }
         leftHingeJoint.spring = leftSpring;

        JointSpring rightSpring = new JointSpring();
        rightSpring.spring = 30000.0f;
        rightSpring.damper = 10.0f;

         if(Input.GetKey(KeyCode.E)){
            rightSpring.targetPosition = 60.0f;
         }
         if(Input.GetKeyUp(KeyCode.E)){
            rightSpring.targetPosition = 0.0f;
         }
         rightHingeJoint.spring = rightSpring;
    }
}