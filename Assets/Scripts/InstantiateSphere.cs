using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateSphere : MonoBehaviour 
{

	private GameObject objCamera;
	private Vector3 SpawnPosition;
	private int DistanceToCamera;
	public Rigidbody projectile;
	public int velocidadProjectile;

	// Use this for initialization
	void Start () 
	{
		objCamera = (GameObject)GameObject.FindWithTag ("MainCamera");
	}
	
	// Update is called once per frame
	public void ShootSphere () 
	{
		SpawnPosition = objCamera.transform.forward * DistanceToCamera + objCamera.transform.position;
		Rigidbody clone;
		clone = Instantiate (projectile, SpawnPosition, transform.rotation) as Rigidbody;
		Physics.IgnoreCollision(clone.GetComponent<Collider>(), GetComponent<Collider>());
		clone.velocity = transform.TransformDirection (Vector3.forward * velocidadProjectile);
	}
}
