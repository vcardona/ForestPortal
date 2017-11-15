using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleTrasportacion : MonoBehaviour 
{

	static Vector3 puntoDeContacto;
	public Transform SpawnPoint;
	public float sumaEnZ;
	public static Vector3 velocidadVector;



	void OnCollisionEnter(Collision other)
	{
		puntoDeContacto = other.contacts[0].point;
		velocidadVector = other.rigidbody.velocity;
		SpawnPoint.transform.position = new Vector3(puntoDeContacto.x + sumaEnZ, puntoDeContacto.y, puntoDeContacto.z);

	}

}
