using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class menuu : MonoBehaviour
{
    [SerializeField] GameObject menu, ayarlar;

    [SerializeField] Toggle tamekrantoggle;

    public bool seskapali;


       
    
    void Start()
    {
        menu.SetActive(true);
        ayarlar.SetActive(false);
        seskapali = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (tamekrantoggle.isOn)
        {
            Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;

        }
        else
        {
            Screen.fullScreenMode = FullScreenMode.Windowed;
        }
    }


    public void basla()
    {

        SceneManager.LoadScene("secim");


    }

    public void ayar()
    {


        ayarlar.SetActive(true);

    }

    public void geri()
    {


        ayarlar.SetActive(false);

    }
    public void kapa()
    {


        Application.Quit();

    }


    public void seskapa()
    {

        AudioListener.volume = 0;
        seskapali = true;

    }

    public void sesac()
    {

        AudioListener.volume = 1;
        seskapali = false;

    }
}
