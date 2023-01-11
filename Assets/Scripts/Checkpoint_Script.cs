using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint_Script : MonoBehaviour
{
    public Transform character;

    private Vector3 spawnPoint;
    void Start()
    {

    }
    void Update()
    {
        if (character.transform.position.y < -10f)
        {
            character.position = spawnPoint;
        }

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Checkpoint"))
        {
            spawnPoint = other.transform.position;

        }
        //if ( other.CompareTag("Finish"))
        //{
            //finish();
        //}
        //if (other.gameObject.CompareTag("Enemy"))
        //{
            
            //spawn();

        //}

    }
    private void spawn()
    {
        character.position = spawnPoint;
    }
}