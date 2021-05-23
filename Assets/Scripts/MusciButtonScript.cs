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
    private bool isColliding = false;
    
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
        if (other.tag == "Hand" && !isColliding)
        {
            isColliding = true;
            consoleSource.clip = buttonSound;
            consoleSource.Play();
            console.JustPlayed(code);    
        }
    }

    private void OnTriggerExit(Collider other)
    {
        IEnumerator touchDelay()
        {
            yield return  new WaitForSeconds(0.3f);
            isColliding = false;
        }
        
        if (other.tag == "Hand" && isColliding)
        {
            StartCoroutine(touchDelay());
        }
    }
}
