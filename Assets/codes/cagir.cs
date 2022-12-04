using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cagir : MonoBehaviour
{
    public player playerScript;


    public GameObject Borular;

    public float height;

    void Start()
    {

        StartCoroutine(SpawnObject());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public IEnumerator SpawnObject()
    {
        while (!playerScript.dead)
        {

          Instantiate(Borular, new Vector3(13, Random.Range(4, 10), 0), Quaternion.identity);


            yield return new WaitForSeconds(1.5f);
            
        }



    }







}
