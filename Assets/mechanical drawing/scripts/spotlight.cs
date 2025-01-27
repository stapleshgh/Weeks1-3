using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spotlight : MonoBehaviour
{
    //creates empty sprite renderer
    SpriteRenderer spriteRenderer;

    //three positions for the spotlight to lerp to
    Vector2 jackiePos;
    Vector2 taroPos;
    Vector2 leoPos;


    void Start()
    {
        //grabs sprite renderer object
        spriteRenderer = GetComponent<SpriteRenderer>();

        //spotlight positions
        jackiePos  = new Vector3(0, -1, 10);
        taroPos = new Vector3(-5.7f, -1, 10);
        leoPos = new Vector3(5.1f, -1, 10);
    }

    // Update is called once per frame
    void Update()
    {
        Console.WriteLine(spriteRenderer.color);
        followCursor();
        
    }

    void followCursor()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (mousePos.x < -2)
        {
            transform.position = Vector3.Lerp(transform.position, taroPos, Time.deltaTime * 4);

        }
        else if (mousePos.x > -2 && mousePos.x < 2)
        {
            transform.position = Vector3.Lerp(transform.position, jackiePos, Time.deltaTime * 4);
        }
        else if (mousePos.x > 2)
        {
            transform.position = Vector3.Lerp(transform.position, leoPos, Time.deltaTime * 4);
        }
    }
}
