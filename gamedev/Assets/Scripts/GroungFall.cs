﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerExit(Collider col){
		if (col.gameObject.tag == "Ball"){
			Invoke("Fall",0.5f);
		}
	}

	void Fall(){
		GetComponentInParent<Rigidbody> ().useGravity = true;
	}
}
