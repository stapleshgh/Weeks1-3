using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taro : MonoBehaviour
{
    public AnimationCurve curve;
    //curves for right arm1, right arm 2, left arm 1 and left arm 2
    public AnimationCurve RAC1;
    public AnimationCurve RAC2;
    public AnimationCurve LAC1;
    public AnimationCurve LAC2;
    float time = 0f;

    //child object references. grabs the arm pivots from the scene
    public GameObject rightArmPivot1;
    public GameObject rightArmPivot2;
    public GameObject leftArmPivot1;
    public GameObject leftArmPivot2;


    // Start is called before the first frame update
    void Start()
    {
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        bounceSprite();
        taroDance();
    }

    void bounceSprite()
    {
        transform.localScale = new Vector3(1, curve.Evaluate(time), 1);

        time += 1.0f * Time.deltaTime;

        if (time > 1)
        {
            time = 0f;
        }
    }

    void taroDance()
    {
        rightArmPivot1.transform.localRotation = Quaternion.Euler(0, 0, RAC1.Evaluate(time));
        rightArmPivot2.transform.localRotation = Quaternion.Euler(0, 0, RAC2.Evaluate(time));
        leftArmPivot1.transform.localRotation = Quaternion.Euler(0, 0, LAC1.Evaluate(time));
        leftArmPivot2.transform.localRotation = Quaternion.Euler(0, 0, LAC2.Evaluate(time));
    }
    
}
