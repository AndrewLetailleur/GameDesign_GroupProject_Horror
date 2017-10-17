using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCode : MonoBehaviour {

	/**
	 * REFERENCES
	 * ==========
	 * http://answers.unity3d.com/questions/1305167/character-movement-component.html
	 * http://answers.unity3d.com/questions/630670/rotate-2d-sprite-towards-moving-direction.html
	 *===========
	 *///end REF

	Animator anime; //for animation, named after Japanese term
	Rigidbody2D rb2D;

	public float horz_Move, vert_Move;
	public float norSpeed = 0.2f; // walking
	public float maxSpeed = 0.5f; // sprinting7
	public float rotValue = 0f; // Rotation value

	public Vector2 velocity, movement; //for velocity reference

	// Use this for initialization
	void Start () {

//		if(GetComponent<Rigidbody2D>()) {
			rb2D = GetComponent<Rigidbody2D> ();
//		} else
//		Debug.LogError("No rigidbody detected");
		//end if

		//EX: anim = GetComponent<Animator>(); // to be verified //anime component

		//get rotation, store rotation to 'rot valve'

		horz_Move = vert_Move = 0; //init zero movement
	}


	void FixedUpdate()
	{
		GetInput();
		//Turn();
	}
		
	void GetInput()
	{
		horz_Move = Input.GetAxis ("Horizontal"); // deals with X axis movement
		vert_Move = Input.GetAxis ("Vertical"); // deals with Y axis movement

		Move ();
	}
		
	void Move() {

		/**
		 * Moves the player towards the direction of player input
		 * Pretty simple, and elegant. So long as a single condition is met.
		 */
		if (horz_Move != 0 || vert_Move != 0) {
			movement = new Vector2 (horz_Move * norSpeed, vert_Move * norSpeed);
			rb2D.velocity = movement;

			velocity = rb2D.velocity;
		} else
			rb2D.velocity = Vector2.zero;
		//end if movement sequence


		/**
		 * Rotates the character to movement direction.
		 * As a bonus, smoothens out rotation to be a bit more 'natural'.
		 * =====
		 * Only quirk was 'x' was moving funny, so I fixed that.
		 */
		if (velocity != Vector2.zero) {
			rotValue = Mathf.Atan2 (-velocity.x, velocity.y) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.AngleAxis(rotValue, Vector3.forward);
		}//end if rotationary

		//I thank this reference for showing me a more elegant sollution

		/**
		 * I thank this reference for showing me a more elegant sollution,
		 * than "Unlimited If Statements, instead of case statements.
		 * Best part is, the power of Mathf is blessed here!
		 * ===
		 */ // 
	}
}