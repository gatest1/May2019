using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject : MonoBehaviour
{
    [SerializedField] private HealthManager healthManager;

    [SerializedField] private float damage;

    void Start()
    {
        healthManager = GameObject.FindGameObjectWithTag("HealthManager").GetComponent<healthManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            healthManager.health -= damage;
            healthManager.UpdateHealth();
        }
    }

}
