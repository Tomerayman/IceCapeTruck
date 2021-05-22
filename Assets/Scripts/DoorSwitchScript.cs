using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitchScript : MonoBehaviour
{
    [SerializeField]
    private Transform doorTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Key"))
        {
            StartCoroutine(rotateDoor());
        }
    }
    
    IEnumerator rotateDoor()
    {
        float time = 0;
        float duration = 1f;
        Vector3 axis = new Vector3(1.3f, 1, -2.4f);
        while (time < duration)
        {
            float angle = Mathf.Lerp(0, 90, time / duration);
            doorTransform.RotateAround(axis, angle);
            time += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
    }
}
