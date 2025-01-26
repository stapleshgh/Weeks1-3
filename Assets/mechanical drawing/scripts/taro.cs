using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taro : MonoBehaviour
{
    public AnimationCurve curve;
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
    
}
