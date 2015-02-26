using UnityEngine;
using System.Collections;

public class AbilityGun : MonoBehaviour
{

    public GameObject projectile;
    public Vector3 offset;
    public Vector3 trajectory = Vector3.forward;
    public float magnitude;
    public float drag = 5;
    public string inputName = "Fire1";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Fire();
        }
    }

    void Fire()
    {
        GameObject clone;
        clone = Instantiate(projectile, transform.position + offset, transform.rotation) as GameObject;
        clone.rigidbody.velocity = transform.TransformDirection(trajectory * magnitude);
    }
}
