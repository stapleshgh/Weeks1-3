using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leo : MonoBehaviour
{
    public AnimationCurve curve;
    float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(1, curve.Evaluate(time), 1);

        time += 1.0f * Time.deltaTime;

        if (time > 1)
        {
            time = 0f;
        }
    }
}
