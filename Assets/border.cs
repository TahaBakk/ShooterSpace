﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class border : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll){
		if(coll.gameObject.name != "playerShip"){
			Destroy(coll.gameObject);
		}
	}
}
