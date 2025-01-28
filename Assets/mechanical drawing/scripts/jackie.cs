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

    //increment speed
    float speed = 1f;

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

        //collects mouse pos
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //checks if mouse is hovering over jackie
        if (mousePos.x > -2 && mousePos.x < 2)
        {
            jackieDance();
        }
    }

    void bounceSprite()
    {
        //sets local scale equal to curve evaluation. same as all other sprites
        transform.localScale = new Vector3(1, curve.Evaluate(time), 1);

        //increments time
        time += speed * Time.deltaTime;

        //resets time if equal to 1
        if (time > 1)
        {
            time = 0f;
        }

        speed = (Camera.main.ScreenToWorldPoint(Input.mousePosition).y + 5) / 5;
    }


    void jackieDance()
    {
        //moves each arm and the head to the beat
        jackieHead.transform.localPosition = new Vector3(jackieHead.transform.localPosition.x, headCurve.Evaluate(time), 1);
        jackieArm1.transform.localPosition = new Vector3(jackieArm1.transform.localPosition.x, armCurve1.Evaluate(time), 2);
        jackieArm2.transform.localPosition = new Vector3(jackieArm2.transform.localPosition.x, armCurve2.Evaluate(time), 1);
    }
}
