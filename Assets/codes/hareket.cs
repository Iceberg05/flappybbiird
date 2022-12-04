using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
 
    public float hiz;


    void Start()
    {

        Destroy(gameObject, 10);
 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Vector3.left * hiz * Time.deltaTime;
    }




}
