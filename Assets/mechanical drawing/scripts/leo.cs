using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leo : MonoBehaviour
{
    public AnimationCurve curve;
    float time = 0f;

    //increment speed
    float speed = 1f;

    
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
        //makes sprite bounce according to the animation curve
        transform.localScale = new Vector3(1, curve.Evaluate(time), 1);

        time += speed * Time.deltaTime;

        if (time > 1)
        {
            time = 0f;
        }

        //grabs mouse position and uses it for animation speed
        speed = (Camera.main.ScreenToWorldPoint(Input.mousePosition).y + 5) / 5;
    }
}
