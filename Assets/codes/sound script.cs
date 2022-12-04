using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundscript : MonoBehaviour
{

    AudioSource puansesi;
    // Start is called before the first frame update
    void Start()
    {
        puansesi = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "oyuncu")
        {
            puansesi.Play();
        }


    }
    }
