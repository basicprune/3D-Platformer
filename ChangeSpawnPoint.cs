using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpawnPoint : MonoBehaviour
{
    public Die die;
    private void Start()
    {
        die = FindObjectOfType<Die>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            die.ChangeSpawnPoint(transform);   
        }
    }
}
