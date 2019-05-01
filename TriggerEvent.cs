using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("HELLO!");
            //I want to say "hello!"
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTagh("Player"))
        {
            Debug.Log("GOODBYE!");
            //I want to say "goodbye!"
        }
    }

    void OnTriggerStay(Collider other)
}
