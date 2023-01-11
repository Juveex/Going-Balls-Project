using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Checkpoint_Script : MonoBehaviour
{
    
    public Transform character;

    private Vector3 _spawnPoint;
    private Rigidbody rb;
    void Start()
    {

    }
    void Update()
    {
        if (character.transform.position.y < -10f)
        {
            character.position = _spawnPoint;
        }

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Checkpoint"))
        {
            _spawnPoint = other.transform.position;

        }
        //if ( other.CompareTag("Finish"))
        //{
            //finish();
        //}
        if (other.gameObject.CompareTag("Kill"))
           {
            //rb.velocity = Vector3.zero;
            //rb.angularVelocity = Vector3.zero;

            character.position = _spawnPoint;
            //spawn();

        }

    }
    private void spawn()
    {
        character.position = _spawnPoint;
    }
}