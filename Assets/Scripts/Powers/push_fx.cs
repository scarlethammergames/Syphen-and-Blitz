﻿using UnityEngine;
using System.Collections;

public class push_fx : MonoBehaviour {
	
	public GameObject effect; //the prefab with the right transparency and color
	public float speed;
	//public float radius;
	private float radius;
	private GameObject GO; //to hold the prefab for use
	private Vector3 v3Scale;
	SphereCollider myCollider;
	
	// Use this for initialization
	void Start () {
		GO = Instantiate(effect, transform.position, transform.rotation) as GameObject;		
		GO.transform.parent = transform;
		v3Scale = Vector3.one;
		myCollider = transform.GetComponent<SphereCollider>();
		radius = myCollider.radius;
	}
	
	// Update is called once per frame
	void Update () {
		if (GO.transform.localScale.x > radius)
			GO.transform.localScale = new Vector3(.5f,.5f,.5f);
		else
			GO.transform.localScale += v3Scale * speed * Time.deltaTime;
	}
}
