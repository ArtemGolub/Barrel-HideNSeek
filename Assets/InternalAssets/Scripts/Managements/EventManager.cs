using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public static EventManager current;
    
    [HideInInspector]public UnityEvent Lose = new UnityEvent();
    [HideInInspector]public UnityEvent Win = new UnityEvent();

    private void Awake()
    {
        current = this;
    }
}
