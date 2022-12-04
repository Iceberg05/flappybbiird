using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float velo = 5f;
    public Rigidbody2D gövde;
    public bool dead;
    public GameManager managerGame;
    AudioSource deadsesi;


   // public GameObject selectedskin;
   // public GameObject Player;

    //private Sprite playersprite;

    void Start()
    {

       // playersprite = selectedskin.GetComponent<SpriteRenderer>().sprite;
        //Player.GetComponent<SpriteRenderer>().sprite = playersprite;
        Time.timeScale = 0;
        deadsesi = GetComponent<AudioSource>();
    
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gövde.velocity = Vector2.up * velo;
        }





    }
    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "skor")
        {
        
            managerGame.AddPoint();
        }

        if (col.gameObject.tag == "ol")
        {
            deadsesi.Play();
            dead = true;
        }

    }
}
