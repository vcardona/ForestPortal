using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySphere : MonoBehaviour 
{

	void OnCollisionEnter(Collision collision)
	{
		if(collision.collider.tag == "Pared")
		{
			
			Destroy(gameObject);
		}

	}

}