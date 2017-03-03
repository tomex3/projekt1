using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public int Speed;
    public int JumpHeight;

    private Rigidbody _rb;


	public void Awake () {
        _rb = GetComponent<Rigidbody>();
	}


    public void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        

        _rb.AddForce(movement * Speed);
	    if (Input.GetKey("r"))
	    {
            _rb.AddForce(Vector3.up * JumpHeight);
            Debug.Log("Wykonało się");
        }


    }
}
