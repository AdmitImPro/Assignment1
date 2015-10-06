/* Author: Arunan Shan */
/* File: ObstacleController.cs */
/* Creation Date: Sept 21, 2015*/
/* Description: This script controls the obstacle speed/drift and spawn of obstacle */
/* Last Modified by: Monday October 5, 2015 */

using UnityEngine;
using System.Collections;
[System.Serializable]  // Make class visible outisde 
public class Speed {
	public float minSpeed, maxSpeed;
}


[System.Serializable]
public class Drift {
	public float minDrift, maxDrift;
}
[System.Serializable]
public class Boundary {
	public float xMin, xMax, yMin, yMax;
}

public class ObstacleController : MonoBehaviour {

	//PUBLIC INSTANCE VARIABLE
	public Speed speed;
	public Boundary boundary;
	public Drift drift;

	//PRIVATE INSTANCE VARIABLE
	private float _CurrentSpeed;
	private float _CurrentDrift;

	// Use this for initialization
	void Start () {
		this._Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 currentPosition = gameObject.GetComponent<Transform> ().position;
		currentPosition.x += this._CurrentDrift;
		currentPosition.y -= this._CurrentSpeed;
		gameObject.GetComponent<Transform> ().position = currentPosition;
		
		// Check bottom boundary
		if (currentPosition.y <= boundary.yMin) {
			this._Reset ();
		}
	}
	//Resets Game Object
	private void _Reset() {
		this._CurrentDrift = Random.Range (drift.minDrift, drift.maxDrift);
		this._CurrentSpeed = Random.Range (speed.minSpeed, speed.maxSpeed);
		Vector2 resetPosition = new Vector2 (Random.Range(boundary.xMin, boundary.xMax),boundary.yMax);
		gameObject.GetComponent<Transform> ().position = resetPosition;
	}
}
