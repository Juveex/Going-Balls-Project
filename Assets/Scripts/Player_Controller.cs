using UnityEngine;
using System.Collections;

public class Player_Controller : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    // Use t$$anonymous$$s for initialization
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        movement = Camera.main.transform.TransformDirection(movement);
        rb.AddForce(movement * speed * Time.deltaTime);
    }
}