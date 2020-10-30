using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3PlayerMovement : MonoBehaviour
{
    // TODO: Implement navigation strategy for this robot

    public Rigidbody rb;

    
    // Called once on the first frame
    void Start() {
		mAudioSource = GetComponent<AudioSource> (); // Ignore this line

        

	}

    
    // Works similar to Update(). Please use this function instead of Update() for this part
    void FixedUpdate() {
        







    }


    // Reduce the speed of the robot to 0
    private void Stop() {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }


    // TODO: Implement this function for moving the robot forward
    private void MoveForward() {
        

    }


    // TODO: Implement this function for moving the robot to the left
    private void MoveLeft() {
        

    }


    // TODO: Implement this function for moving the robot to the right
    private void MoveRight() {
        

    }


    // TODO: implements this function so when called,
    // the robot will look ahead a distance d and return the tag of the object it sees (if any)
    // hit.transform.tag returns the tag of the object a raycast hits
    private string LookAhead(float d) {




        return ""; 
    }


    // TODO: implements this function so when called,
    // the robot will look directly left a distance d and return the tag of the object it sees (if any)
    private string LookLeft(float d) {
        




        return ""; 
    }


    // TODO: implements this function so when called,
    // the robot will look directly right a distance d and return the tag of the object it sees (if any)
    private string LookRight(float d) {
        





        return ""; 
    }


    // ----------IGNORE ME-----------
    public AudioClip CoinSound;
    private AudioSource mAudioSource = null; 
    
    void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag.Equals ("Coin")) {
            mAudioSource.PlayOneShot(CoinSound);			
			Destroy(other.gameObject);
		}
	}
}