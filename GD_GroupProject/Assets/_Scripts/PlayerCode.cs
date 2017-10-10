using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCode : MonoBehaviour {

	/* REFERENCES
	 http://answers.unity3d.com/questions/1305167/character-movement-component.html
	*/ //end REF

	Animator anime; //for animation, named after Japanese term
	Rigidbody2D rb2D;

//	public Quaternion TargetRotation
//	{
//		get { return TargetRotation; }
//	} //rotation practice, from this link 

	//facing rotation

	public float horz_Move, vert_Move;
	public float norSpeed = 0.2f; // walking
	public float maxSpeed = 0.5f; // sprinting7
	public float zz = 0f;

	public Vector2 velocity, movement; //for velocity reference
	// est values, like 'rotation' perhaps?

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


		movement = new Vector2 (horz_Move * norSpeed, vert_Move * norSpeed);


		if (horz_Move != 0){
		/*	rb2D.velocity = movement; */	//rotate Z instead
			zz += horz_Move;
			transform.rotation = Quaternion.Euler(0,0, zz);
		}
		else if (vert_Move != 0)
			rb2D.velocity = movement;
		else
			rb2D.velocity = Vector2.zero;

	// set rotation to 'rot valve'

	//for reference

	//		rigidbody2D.MovePosition;	// for movement, direction
	//		rigidbody2D.MoveRotation;	// for rotation, turn

	//		rigidbody2D.velocity = new Vector3 (horzMov * norSpeed, vertMov * norSpeed);

}
}
