using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    private Vector3 direction = Vector3.forward;
   

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime);
        if(transform.position.x >= 2.5f)
        {
            direction = Vector3.forward;
            transform.localScale = new Vector3(3.5f, 3.5f, 3.5f);
        }
        if (transform.position.x <= -2.5f)
        {
            direction = Vector3.back;
            transform.localScale = new Vector3(3.5f, 3.5f, -3.5f);
        }
    }
}
