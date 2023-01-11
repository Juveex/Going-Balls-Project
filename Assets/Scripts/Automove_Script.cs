using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automove_Script : MonoBehaviour
{
    public float maxValue = 15; // or whatever you want the max value to be
    public float minValue = -15; // or whatever you want the min value to be
    public float currentValue; // or wherever you want to start
    public float direction = 1;
    public float y;
    public float z;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentValue += speed* Time.deltaTime * direction; // or however you are incrementing the position
        if (currentValue >= maxValue)
        {
            direction *= -1;
            currentValue = maxValue;
        }
        else if (currentValue <= minValue)
        {
            direction *= -1;
            currentValue = minValue;
        }
        transform.position = new Vector3(currentValue, y, z);
    }
}