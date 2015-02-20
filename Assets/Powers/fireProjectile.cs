//Reference: http://docs.unity3d.com/ScriptReference/Object.Instantiate.html

using UnityEngine;
using System.Collections;

/**
* Spawn a rigid body GameObject with an initial velocity when triggered. 
* Constraints: The projectile must contain a rigid body.
*/
public class fireProjectile: MonoBehaviour {

	public GameObject projectile;
	public Vector3 offset;
	public Vector3 trajectory = Vector3.forward;
	public float magnitude;
	public float drag = 5;
	public string inputName = "Fire1";

	void Update () {
		if (Input.GetKeyDown(KeyCode.Q)){
			Fire();
		}
	}

	void Fire(){
		GameObject clone;
		clone = Instantiate( projectile, transform.position + offset, transform.rotation ) as GameObject;
		clone.rigidbody.velocity = transform.TransformDirection( trajectory * magnitude );
	}
}
