using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taro : MonoBehaviour
{
    //curve that controls the bouncing. its the same for all the sprites which makes me think i could make a base class for this but that's kind of out of the scope of this project
    public AnimationCurve curve;
    //curves for right arm1, right arm 2, left arm 1 and left arm 2
    public AnimationCurve RAC1;
    public AnimationCurve RAC2;
    public AnimationCurve LAC1;
    public AnimationCurve LAC2;

    //curve time
    float time = 0f;
    //increment speed
    float speed = 1f;

    //child object references. grabs the arm pivots from the scene
    public GameObject rightArmPivot1;
    public GameObject rightArmPivot2;
    public GameObject leftArmPivot1;
    public GameObject leftArmPivot2;


    // Start is called before the first frame update
    void Start()
    {
        //resets the time variable
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //call the bounce function
        bounceSprite();

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //checks if mouse is hovering over taro
        if (mousePos.x <-2)
        {
            taroDance();
        }

    }

    void bounceSprite()
    {
        //sets the local scale to the curve at the current time
        transform.localScale = new Vector3(1, curve.Evaluate(time), 1);

        //adds the speed to the curve multiplied by the delta time
        time += speed * Time.deltaTime;

        //resets the timer if it hits 1
        if (time > 1)
        {
            time = 0f;
        }

        speed = (Camera.main.ScreenToWorldPoint(Input.mousePosition).y + 5) / 5;
    }

    void taroDance()
    {
        //rotates each limb independently according the the curve's evaluation.
        //worth noting that this works exclusively because the curve itself is set to the values needed. this would not work at scale because I would have to do that for every single little thing, which sucks
        rightArmPivot1.transform.localRotation = Quaternion.Euler(0, 0, RAC1.Evaluate(time));
        rightArmPivot2.transform.localRotation = Quaternion.Euler(0, 0, RAC2.Evaluate(time));
        leftArmPivot1.transform.localRotation = Quaternion.Euler(0, 0, LAC1.Evaluate(time));
        leftArmPivot2.transform.localRotation = Quaternion.Euler(0, 0, LAC2.Evaluate(time));
    }
    
}
