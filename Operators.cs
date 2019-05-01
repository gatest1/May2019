using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operators : MonoBehaviour
{
    [SerializeField]
    private InputField outputCalc;
    private float finalSum;

    private float a = 1;
    private float b = 2;
    private float c = 3;
    private float d = 4;
    private float e = 1;

    void YourOperators()
    {
        //finalSum = a + b;
        //finalSum = c * d;

        if (a = 2 || b = 2)
        {
            finalSum++;
        }
    }
    public void CalculationButton()
    {
        YourOperators();
        outputCalc.text = outputCalc.text + finalSum;
    }

    public void ClearCalculationButton()
    {
        outputCalc.text = "";
    }
}
