using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class hourHand : MonoBehaviour
{
    public int clockSpeed = -12;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, clockSpeed));
    }
}
