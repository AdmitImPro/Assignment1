/* Author: Arunan Shan */
/* File: GameController.cs */
/* Creation Date: Sept 21, 2015 */
/* Description: This script creates obstacles in the game */
/* Last Modified by: Monday October 5, 2015 */

using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	//PUBLIC INSTANCE VARIABLES
	public int obstacleCount;
	public GameObject obstacle;


	// Use this for initialization
	void Start () {


		this._GenerateObjects ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R))//input is "press "r" for restart
		{
			Debug.Log("Restarted!");
			Application.LoadLevel(Application.loadedLevel);
		}
		}
		
		//Genertate Objects
		private void _GenerateObjects () {
		for(int count = 0; count < this.obstacleCount; count++)
		{
			Instantiate(obstacle);
		}
		


}
}

