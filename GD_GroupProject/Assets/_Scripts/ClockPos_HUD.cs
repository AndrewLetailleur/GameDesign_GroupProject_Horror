using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockPos_HUD : MonoBehaviour {

	Vector3 pos;
	float height, width;
	public float sZ = 7f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update() {
		height = Camera.main.orthographicSize * 2;
		width = height * Screen.width/ Screen.height;

		pos = new Vector3(0.85F, 0.87F, sZ);
		transform.position = Camera.main.ViewportToWorldPoint(pos);


		if (height < width)
			transform.localScale = Vector3.one * height / 6f;
		else
			transform.localScale = Vector3.one * width / 6f;
	}
}

//transform.position = Camera.main.ScreenToViewportPoint(0.9, 0.9, 10);

