using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LeverScript : MonoBehaviour
{
    private bool _leverStatus;
    private Animator _anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InteractWithLever()
    {
        if (_leverStatus == false)
        {
            Debug.Log(_leverStatus);
        }

        else
        {
            Debug.Log(_leverStatus);
        }
    }
}
