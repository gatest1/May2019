using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public float health = 100;

    [SerializedField] private Text healthUI;

    void Start()
    {
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        healthUI.text = health.ToString("0");
    }
  
}
