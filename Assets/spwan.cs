using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwan : MonoBehaviour {

	public GameObject ship;
	public float interval = 1;

	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnNext", interval, interval); //llama al metodo Fire cada cierto tiempo "interval"=tiempo
	}
	
	// Update is called once per frame
	void SpawnNext () {
		Instantiate(ship, transform.position, Quaternion.identity);
	}
}
