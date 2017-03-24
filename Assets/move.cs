﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	public float speed = 5.0f;
	
	// Update is called once per frame
	void FixedUpdate () {
		
		float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw("Vertical");

		Vector2 dir = new Vector2(h,v);
		GetComponent<Rigidbody2D>().velocity = dir.normalized * speed;
		GetComponent<Animator>().SetBool("flying", (v > 0));
	}
}
