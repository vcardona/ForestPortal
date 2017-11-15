using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPArticle : MonoBehaviour {


	public int timeToDestroy;
	// Use this for initialization
	void Start () 
	{
		Destroy(gameObject, timeToDestroy);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
