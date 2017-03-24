using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDamageEnemy : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll){
		if(coll.gameObject.tag == "shipPlayer"){
			Destroy(coll.gameObject);
		}
		Destroy(gameObject);
	}
}
