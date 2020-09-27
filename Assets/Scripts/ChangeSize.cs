using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class ChangeSize : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)  //Unity function called when a collision is detected, and the object collided is put into the variable 'col' to be used later
    {
        if (col.gameObject.name == "Hammer")   //if the object you collided with is the enemy
        {
            transform.localScale += new Vector3(0, 0, 1); //increase the size of the ball
            
            //Destroy(col.gameObject);  //Destroy the enemy
        }
        
    }
}
