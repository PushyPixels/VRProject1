using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventOnCollide : MonoBehaviour
{
    public UnityEvent buttonEvent;

    void OnTriggerEnter()
    {
        buttonEvent.Invoke();
    }
}
