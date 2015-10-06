/* Author: Arunan Shan */
/* File: Scroll.cs */
/* Creation Date: Sept 21, 2015 */
/* Description: This script controls the Map scrolling speed */
/* Last Modified by: Monday September 21, 2015 */

using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

	//PUBLIC INSTANCE VARIABLES
	public float speed = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector2 offset = new Vector2 (Time.time * speed, 0);

		GetComponent<Renderer>().material.mainTextureOffset = offset; // Repeats background
	}
}
