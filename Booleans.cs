using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booleans : MonoBehaviour
{
    public bool isTrue;
    private bool isHappening;

    void Start()
    {
        isTrue = true;
        isHappening = true;
    }

    void Update()
    {
        if (!isTrue)
        {
            Debug.Log("I'm Activated!");
            isHappening = false;
        }

        if (isHappening)
        {
            Debug.Log("IsHappening");
        }
    }
}
