using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class oyunmanager : MonoBehaviour
{
    [SerializeField] GameObject deadd,esc,devampaneli,dur;

    public menuu menu;

    public player playerdead;
    void Start()
    {
        menu = GetComponent<menuu>();
        devampaneli.SetActive(true);
        deadd.SetActive(false);
        esc.SetActive(false);

        dur.SetActive(false);
    }



    void Update()
    {

        if (playerdead.dead == true)
        {
            Time.timeScale = 0;
            deadd.SetActive(true);
            dur.SetActive(false);

        }

        


    }

    public void devvam()
    {


        SceneManager.LoadScene("oyun");

    }

    public void devvammavi()
    {


        SceneManager.LoadScene("mavioyun");

    }

    public void devvamsari()
    {


        SceneManager.LoadScene("sarioyun");

    }

    public void devvambeyaz()
    {


        SceneManager.LoadScene("beyazoyun");

    }



    public void menuye()
    {


        SceneManager.LoadScene("menuu");

    }

    public void adios()
    {


        Application.Quit();

    }

    public void stop()
    {

        esc.SetActive(true);
        Time.timeScale = 0;


    }

    public void go()
    {

        esc.SetActive(false);
        Time.timeScale = 1;

    }

    public void devvvvam()
    {
        dur.SetActive(true);
        devampaneli.SetActive(false);
        Time.timeScale = 1;


    }







}
