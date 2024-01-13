using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider))]
public class FinishFlag : MonoBehaviour
{
    private void Start()
    {
        GetComponent<BoxCollider>().isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<PlayerComponents>();
        if (player)
        {
            EventManager.current.Win.Invoke();
        }
    }
}
