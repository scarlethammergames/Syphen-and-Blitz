using UnityEngine;
using System.Collections;

//need to fix spawn direction/rotation
// or fix player prefab rotation...

public class PowerController : MonoBehaviour {

	public GameObject rangePullPrefab;
	public GameObject rangePushPrefab;
	public GameObject closePullPrefab;
	public GameObject closePushPrefab;

	public float offset;
	public Vector3 trajectory = Vector3.forward;
	public float magnitude;
	public float drag = 5;
	public string inputName = "Fire1";
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.Alpha1)){
			//print("keypad1 was pressed");
			FireRangePull();
		}
		/*
		if (Input.GetKeyDown(KeyCode.Alpha1)){
			//FireRangePull();
		}
		if (Input.GetKeyDown(KeyCode.Alpha1)){
			//FireRangePull();
		}
		if (Input.GetKeyDown(KeyCode.Alpha1)){
			//FireRangePull();
		}*/
	}

	void FireRangePull(){

		GameObject clone;
		Vector3 playerPos = transform.position;
		Vector3 playerDirection = transform.forward;
		Quaternion playerRotation = transform.rotation;
		Vector3 spawnPos = playerPos + playerDirection*offset;
		//the leaning walk can make the clone spawn in bad places
		if (spawnPos.y < 1)
			spawnPos.y = 1;

		clone = Instantiate( rangePullPrefab, spawnPos, playerRotation ) as GameObject;
		clone.rigidbody.velocity = transform.TransformDirection( playerDirection * magnitude );
	}
}
