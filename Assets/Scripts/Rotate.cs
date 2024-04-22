using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public float pitch=0.0f, yaw=360.0f, roll=0.0f;
    public Space space = Space.World;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(pitch*Time.deltaTime, yaw*Time.deltaTime, roll*Time.deltaTime, space);
    }
}
