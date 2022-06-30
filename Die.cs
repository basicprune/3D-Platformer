using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<CharacterController>().enabled = false;
            other.transform.position = spawnPoint.position;
            other.GetComponent<CharacterController>().enabled = true;
        }
    }

    public void ChangeSpawnPoint(Transform newSpawnPoint)
    {
        spawnPoint = newSpawnPoint; 
    }
}
