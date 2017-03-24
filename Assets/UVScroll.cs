using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UVScroll : MonoBehaviour {

	// Use this for initialization
	public Vector2 speed;

    void LateUpdate() {
        GetComponent<Renderer>().material.mainTextureOffset = speed * Time.time;
    }
}
