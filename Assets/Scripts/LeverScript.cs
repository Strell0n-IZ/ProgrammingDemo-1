using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;

public class LeverScript : MonoBehaviour
{
    public bool _leverStatus;
    public Animator _anim;
    [SerializeField] public UnityEvent _event;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwapInteract()
    {
        _leverStatus = !_leverStatus;
        Debug.Log(_leverStatus + " Lever");            
        _anim.SetBool("LeverStatus", _leverStatus);

        //_event.Invoke();
        //_leverStatus = !_leverStatus;



        /*if (_leverStatus == false)
        {
            Debug.Log(_leverStatus);            
            _anim.SetBool("LeverStatus", true);
            _event.Invoke();
            _leverStatus = !_leverStatus;
        }

        else if (_leverStatus == true)
        {
            Debug.Log(_leverStatus);
            _anim.SetBool("LeverStatus", false);
            
            _leverStatus = !_leverStatus;
        }*/
    }

     /*void IInteractable.interact()
    {
        interact();
    }*/
}
