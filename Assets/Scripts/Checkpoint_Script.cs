using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint_Script : MonoBehaviour
{
    
    public Transform character;

    private Vector3 _spawnPoint;
    private Rigidbody _rb;
    Move_Script move;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        move = GetComponent<Move_Script>();
    }
    void Update()
    {
        if (character.transform.position.y < -10f)
        {
            //rb.velocity = Vector3.zero;
            //rb.angularVelocity = Vector3.zero;
            //move.speed = 0
            character.position = _spawnPoint;
           //ove.isMoving = false;
            _rb.velocity = Vector3.zero;
            _rb.angularVelocity = Vector3.zero;
          
        }

    }
    public void OnTriggerEnter(Collider other)
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
            //move.speed = 0;
            character.position = _spawnPoint;
            //spawn();
            _rb.velocity = Vector3.zero;
            _rb.angularVelocity = Vector3.zero;
        }

    }
    private void spawn()
    {
        //_rb.velocity = Vector3.zero;
        //_rb.angularVelocity = Vector3.zero;
        //_rb.Sleep();
        character.position = _spawnPoint;

    }
}