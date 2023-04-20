using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int random = Random.Range(1, 5);
        Destroy(gameObject, random);
    }

}
