using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableEnableScripts : MonoBehaviour
{
    public GameObject floor;
    private GameObject player2;

    void Start()
    {
        cubeObject2 = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            floor.GetComponent<MeshRenderer>().enabled = false;
            player2.GetComponent<FirstScript>().enabled = false;  
        }
    }
}
