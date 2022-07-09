using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightMove : MonoBehaviour
{
    public float speed = 8f;
   
    void Update()
    {
        Vector3 pos = transform.position;

        if(Input.GetKey("a"))

        {
            pos.x -= speed * Time.deltaTime;
        }

        if(Input.GetKey("d"))

        {
            pos.x += speed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
