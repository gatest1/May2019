using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKeyType : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("TB"))
        {
            Debug.Log("DO SOMETHING HERE!");
        }

        if (Input.GetButton("TT"))
        {
            Debug.Log("DO SOMETHING ELSE!");
        }
    }
}
