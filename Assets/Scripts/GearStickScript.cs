using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GearStickScript : MonoBehaviour
{
    public Vector3 goalPos;
    public Quaternion goalRot;
    private Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GearBox"))
        {
            GetComponent<XRGrabInteractable>().enabled = false;
            transform.position = goalPos;
            transform.rotation = goalRot;
            _rb.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
