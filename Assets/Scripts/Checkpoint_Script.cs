using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckPoint : MonoBehaviour
{
    public Transform chracter;

    private Vector3 spawnPoint;
    void Start()
    {

    }
    void Update()
    {
        if (chracter.transform.position.y < -20f)
        {
            chracter.position = spawnPoint;
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
        chracter.position = spawnPoint;
    }
}