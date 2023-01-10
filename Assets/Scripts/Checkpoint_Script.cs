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
        if (character.transform.position.y < -20f)
        {
            character.position = spawnPoint;
        }

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("CheckPoint"))
        {
            spawnPoint = other.transform.position;

        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            //Destroy(gameObject);
            spawn();

        }

    }
    private void spawn()
    {
        character.position = spawnPoint;
    }
}