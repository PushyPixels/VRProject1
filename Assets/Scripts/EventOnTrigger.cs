using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventOnTrigger : MonoBehaviour
{
    public UnityEvent buttonEvent;

    void OnTriggerEnter()
    {
        buttonEvent.Invoke();
    }
}
