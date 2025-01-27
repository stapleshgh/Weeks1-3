using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jackie : MonoBehaviour
{
    public AnimationCurve curve;
    public AnimationCurve headCurve;
    public AnimationCurve armCurve1;
    public AnimationCurve armCurve2;
    float time = 0f;

    //child object references. grabs the arm pivots from the scene
    public GameObject jackieHead;
    public GameObject jackieArm1;
    public GameObject jackieArm2;


    // Start is called before the first frame update
    void Start()
    {
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        bounceSprite();
    }

    void bounceSprite()
    {
        transform.localScale = new Vector3(1, curve.Evaluate(time), 1);

        time += 1.0f * Time.deltaTime;

        if (time > 1)
        {
            time = 0f;
        }

        jackieHead.transform.localPosition = new Vector2(jackieHead.transform.localPosition.x, headCurve.Evaluate(time));
        jackieArm1.transform.localPosition = new Vector3(jackieArm1.transform.localPosition.x, armCurve1.Evaluate(time), 2);
        jackieArm2.transform.localPosition = new Vector3(jackieArm2.transform.localPosition.x, armCurve2.Evaluate(time), -1);
    }


    void jackieDance(float t)
    {
        jackieHead.transform.localPosition = new Vector2(jackieHead.transform.localPosition.x, headCurve.Evaluate(t));
        jackieArm1.transform.localPosition = new Vector3(jackieArm1.transform.localPosition.x, armCurve1.Evaluate(t), 2);
        jackieArm2.transform.localPosition = new Vector3(jackieArm2.transform.localPosition.x, armCurve2.Evaluate(t), -1);
    }
}
