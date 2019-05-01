using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditional : MonoBehaviour
{
    public int score;
    public bool checkpoint;
    public Functions otherScript;

    void Update()
    {
        if (score == 50)
        {
            if (checkpoint)
            {
                otherScript.GetComponent<Functions>().Death();
            }
        }

       else if (score == 40 && !checkpoint)
        {
            Debug.Log("Score IS 40!");
        }

        else
        {
            Debug.Log("Score IS 0!");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("SCORE IS 0!");
        }
    }
}
