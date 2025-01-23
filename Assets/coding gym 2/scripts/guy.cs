using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guy : MonoBehaviour
{
    int speed = 10;
    int direction = 1;

    float time = 0;

    bool jumping = false;

    public AnimationCurve curve;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed * direction * Time.deltaTime, 0, 0);

        checkCollisions();

        if (jumping)
        {
            time += 1.0f * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, curve.Evaluate(time), 0);
        }

        if (time > 1)
        {
            time = 0;
            jumping = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && !jumping)
        {
            jump();
        }
    }


    void checkCollisions()
    {
        if (transform.position.x > 7 || transform.position.x < -7)
        {
            speed *= -1;
        }
    }

    void jump()
    {
        time = 0;
        jumping = true;
        
    }
}
