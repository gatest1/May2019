using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCubeBool : MonoBehaviour
{
    public GameObject cube1;
    public GameObject cube2;

    public bool cubeBool;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cubeBool = true;
            Cubes();
        }
    }

    void Cubes()
    {
        if (cubeBool)
        {
            cube1.SetActive(false);
            cube2.SetActive(false);
        }
    }
}
