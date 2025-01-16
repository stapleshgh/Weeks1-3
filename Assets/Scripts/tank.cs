using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank : MonoBehaviour
{
    public int tankRotation = 0;
    public GameObject turret = null;

    // Start is called before the first frame update
    void Start()
    {
        turret = transform.GetChild(2).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //handles turret rotations
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0;
        Vector2 direction = mouse - turret.transform.position;

        turret.transform.up = direction;

        //movement code: detects a or d, moves in that direction

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-2 * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(2 * Time.deltaTime, 0, 0);
        }
    }
}
