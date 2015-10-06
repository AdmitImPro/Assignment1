/* Author: Arunan Shan */
/* File: SCoinController.cs */
/* Creation Date: Sept 28, 2015 */
/* Description: This script controls the Silver Coin spawn */
/* Last Modified by: Monday October 5, 2015 */

using UnityEngine;
using System.Collections;

public class SCoinController : MonoBehaviour {

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
		if (currentPosition.y <= -50) {
			this._Reset();
		}
		
		
	}

	//Resets Game Object
	private void _Reset() {
		Vector2 resetPosition = new Vector2 (Random.Range(7.5f, -7.5f), 50f);
		gameObject.GetComponent<Transform> ().position = resetPosition;
	}
}
