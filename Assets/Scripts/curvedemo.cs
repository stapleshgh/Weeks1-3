using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curvedemo : MonoBehaviour
{

    public AnimationCurve curve;
    public float t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += 0.01f;
        transform.localScale = Vector2.one * curve.Evaluate(t);
    }
}
