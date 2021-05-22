using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusciButtonScript : MonoBehaviour
{
    public AudioClip buttonSound;
    public AudioSource consoleSource;
    public MusicConsoleScript console;
    public string code;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hand")
        {
            Debug.Log("hine");
            consoleSource.clip = buttonSound;
            consoleSource.Play();
            console.JustPlayed(code);    
        }
    }

}
