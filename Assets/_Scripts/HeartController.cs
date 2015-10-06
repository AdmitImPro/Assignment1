/* Author: Arunan Shan */
/* File: HeartController.cs */
/* Creation Date: Sept 28, 2015 */
/* Description: This script controls the obstacle speed and spawn of the heart */
/* Last Modified by: Monday October 5, 2015 */

using UnityEngine;
using System.Collections;

public class HeartController : MonoBehaviour {

	//PUBLIC INSTANCE VARIABLES
	public float speed;
	
	// Use this for initialization
	void Start () {
		this._Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 currentPosition = gameObject.GetComponent<Transform> ().position;
		currentPosition.y -= speed;
		gameObject.GetComponent<Transform> ().position = currentPosition;
		
		
		
		// Check bottom boundary
		if (currentPosition.y <= -500) {
			this._Reset();
		}
		
		
	}
	// Resets game object 
	private void _Reset() {
		Vector2 resetPosition = new Vector2 (Random.Range(7.5f, -7.5f), 100f);
		gameObject.GetComponent<Transform> ().position = resetPosition;
	}
}
