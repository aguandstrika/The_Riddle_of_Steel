using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGrinder : MonoBehaviour
{
    public GameObject grinder;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        grinder.transform.Rotate(Vector3.forward, Time.deltaTime * speed);
    }
}
