﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	//player name should be eventually replaced with system or robot in all scripts and documentation

	public GameObject Player; //self
	public Rigidbody rb; //for collisions and parking system in place

	void Start()
	{
		Debug.Log ("hello");
		rb = GetComponent<Rigidbody> ();
	}

	void Update ()
	{
		//do nothing
	}
}


	

	

