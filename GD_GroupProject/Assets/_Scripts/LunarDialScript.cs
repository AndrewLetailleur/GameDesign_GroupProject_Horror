using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //needed to access time out trigger

public class LunarDialScript : MonoBehaviour {

	public float r_Val = -5f;
	public float cZ_rot = 360;
	public float t_lmt = 200;
	public bool to_flag = false;
	// Use this for initialization
	void Start () { 
		to_flag = false;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 0, r_Val) * Time.deltaTime);


		cZ_rot = transform.rotation.eulerAngles.z;

		if ((cZ_rot < t_lmt) && (cZ_rot > 42)) {
			to_flag = true;
		}


		if (to_flag)
			SceneManager.LoadScene("TimeOut"); //trig condition wise
	}
}
