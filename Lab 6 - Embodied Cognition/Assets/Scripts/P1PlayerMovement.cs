using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1PlayerMovement : MonoBehaviour
{
    // TODO: Implement navigation strategy for this robot
    
    public Rigidbody rb;

    private bool dodgeRight = false; // Indicate if the robot should dodge to the right

    
    // Update is called once per frame
    void Update() {




    }

    
    // Called when colliding with another object
    // collision.collider.tag will return the tag of the obstacle it collided with (e.g. Floor, Wall, Obstacle, etc.)
    void OnCollisionEnter(Collision collision) {
        



    }


    // TODO: Implement this function for moving the robot forward
    private void MoveForward() {
        

    }


    // TODO: Implement this function so that when it is called,
    // the ball will dodge to the left or the right  
    private void DodgeLeftOrRight(float dodgeForce) {
        



    }

}