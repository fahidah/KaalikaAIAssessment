﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnBreakScript : MonoBehaviour {

	
	public GameObject unbrokenColumn;
	public GameObject brokenColumn;
	public GameObject explodeEffect;
	public GameObject ObjectToDestroy;

	//this determines whether the column will be broken or unbroken at the at runtime
	public bool isBroken;


	void Start()
	{ 
		if (isBroken) {
			BreakColumn ();
		} else {
			unbrokenColumn.SetActive (true);
			brokenColumn.SetActive (false);
		}
	}


	public void BreakColumn()
	{
		isBroken = true;
		unbrokenColumn.SetActive (false);
		Instantiate(explodeEffect, transform.position, transform.rotation);
		brokenColumn.SetActive (true);
		Destroy(ObjectToDestroy, .3f);
		
	}



}