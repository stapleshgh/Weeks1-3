using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class SecondScript : MonoBehaviour
{
    float speed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed, 0, 0);

        if (transform.position.x > 10 || transform.position.x < -10)
        {
            speed *= -1;
        }
    }
}
