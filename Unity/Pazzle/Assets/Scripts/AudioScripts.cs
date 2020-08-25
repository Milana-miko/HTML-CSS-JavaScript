using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioScripts : MonoBehaviour
{
    public AudioSource AudioS;
    public GameObject MusicButtonPlay;
    public GameObject MusicButtonStop;
    


    void Start()
    {
        AudioS.Play();
        MusicButtonPlay.SetActive(true);
        MusicButtonStop.SetActive(false);
    }
    
    private void Update()
    {
        if (Input.GetButtonUp("MusicButtonPlay"))
        { 
            AudioS.GetComponent<AudioSource>().Stop() ;
            MusicButtonPlay.SetActive(false);
            MusicButtonStop.SetActive(true);

        }


    }

}





