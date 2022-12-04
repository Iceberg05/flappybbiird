using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class butonses : MonoBehaviour
{
    public AudioSource Ses;
    public AudioClip sesClip;
    private void Awake()
    {
        foreach (Button obje in Resources.FindObjectsOfTypeAll<Button>())
        {
            obje.onClick.AddListener(() => SesCalmas());
        }


    }

    public void SesCalmas()

    {

        Ses.PlayOneShot(sesClip, 1);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
