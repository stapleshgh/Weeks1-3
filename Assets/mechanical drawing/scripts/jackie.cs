using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jackie : MonoBehaviour
{
    //creating animation curves for the bounce, head, and both arms
    public AnimationCurve curve;
    public AnimationCurve headCurve;
    public AnimationCurve armCurve1;
    public AnimationCurve armCurve2;

    //curve time variable. each curve only needs one since they are in sync
    float time = 0f;

    //child object references. grabs the arm pivots from the scene
    public GameObject jackieHead;
    public GameObject jackieArm1;
    public GameObject jackieArm2;


    // Start is called before the first frame update
    void Start()
    {
        //resets time variable
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        bounceSprite();
    }

    void bounceSprite()
    {
        //sets local scale equal to curve evaluation. same as all other sprites
        transform.localScale = new Vector3(1, curve.Evaluate(time), 1);

        //increments time
        time += 1.0f * Time.deltaTime;

        //resets time if equal to 1
        if (time > 1)
        {
            time = 0f;
        }

        
    }


    void jackieDance(float t)
    {
        //moves each arm and the head to the beat
        jackieHead.transform.localPosition = new Vector3(jackieHead.transform.localPosition.x, headCurve.Evaluate(t), 1);
        jackieArm1.transform.localPosition = new Vector3(jackieArm1.transform.localPosition.x, armCurve1.Evaluate(t), 2);
        jackieArm2.transform.localPosition = new Vector3(jackieArm2.transform.localPosition.x, armCurve2.Evaluate(t), 1);
    }
}
