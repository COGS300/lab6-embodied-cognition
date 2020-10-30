using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2PlayerMovement : MonoBehaviour
{
    // TODO: Implement navigation strategy for this robot

    public Rigidbody rb;

    private bool onGround = true; // indicate whether the robot is on the ground

    
    // Update is called once per frame
    void Update() {




        
    }


    // Called when colliding with another object
    // collision.collider.tag will return the tag of the obstacle it collided with (e.g. Floor, Wall, Obstacle, etc.)
    void OnCollisionEnter(Collision collision) {
        if (collision.collider.tag == "Floor") {
            onGround = true;
        }


    }

    
    // TODO: Implement this function for moving the robot forward
    private void MoveForward() {
        rb.AddForce(0, 0, 200f * Time.deltaTime);
    }

    
    //--------GIVEN FUNCTIONS---------

    // Looks ahead with the distance indicated and returns true if
    // there is an obstacle within that distance ahead of the robot
    private bool ObstacleAhead(float distance) {
        RaycastHit hit;
        
        if (Physics.Raycast(transform.position, Vector3.forward, out hit, distance)) {
            if (hit.transform.tag == "Obstacle") {
                return true;
            }
        }

        return false;
    }


    // Jump forward a certain distance
    private void Jump() {
        if (onGround) {
            rb.AddForce(0,400f,100f);
            onGround = false;
        }
    }    
}