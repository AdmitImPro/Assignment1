/* Author: Arunan Shan */
/* File: PlayerCollider.cs */
/* Creation Date: Sept 21, 2015*/
/* Description: This script controls the players interaction with other game objects, game score and reset */
/* Last Modified by: Monday October 5, 2015 */

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerCollider : MonoBehaviour {
	
	//PUBLIC INSTANCE VARIABLES
	public Text scoreLabel;
	public Text livesLabel;
	public Text gameOverLabel;
	public Text finalScoreLabel;
	public Text restartLabel;
	public int  scoreValue = 0;
	public int  livesValue = 3;


	
	// PRIVATE INSTANCE VARIABLES
	private AudioSource[] _audioSources; // An array of AudioSources
	private AudioSource _obstacleAudioSource, _coinAudioSource, _lifeAudioSource, _endAudioSource;


	
	// Use this for initialization
	void Start () {
		this._audioSources = this.GetComponents<AudioSource> ();
		this._obstacleAudioSource = this._audioSources [1];
		this._coinAudioSource = this._audioSources [2];
		this._lifeAudioSource = this._audioSources [3];
		this._endAudioSource = this._audioSources [4];

		
		this._SetScore ();
		this.gameOverLabel.enabled = false; // Hides end game text 
		this.finalScoreLabel.enabled = false;
		this.restartLabel.enabled = false;
	}
	
	// Update is called once per frame

	void Update () {
		
		
		
	}

	
	void OnTriggerEnter2D(Collider2D otherGameObject) {
	
		
		if (otherGameObject.tag == "Coin") {
			this._coinAudioSource.Play (); // play coin sound
			this.scoreValue += 10; // add 10 points
		}
		if (otherGameObject.tag == "SCoin") {
			this._coinAudioSource.Play (); // play coin sound
			this.scoreValue += 5; // add 5 points
		}
		if (otherGameObject.tag == "BCoin") {
			this._coinAudioSource.Play (); // play coin sound
			this.scoreValue += 1; // add 1 points
		}
		if (otherGameObject.tag == "Heart") {
			this._lifeAudioSource.Play (); // play life sound
			this.livesValue += 1; // add 1 points
		}
		if (otherGameObject.tag == "Obstacle") {
			this._obstacleAudioSource.Play (); // play hit sound
			this.livesValue -= 1; // remove one life
			if(this.livesValue <= 0) {

				this._EndGame();
			}
		}
		this._SetScore ();

	}
	
	// PRIVATE METHODS
	private void _SetScore() {
		this.scoreLabel.text = "Score: " + this.scoreValue;
		this.livesLabel.text = "Lives: " + this.livesValue;
	}
	
	private void _EndGame() {
		Destroy(gameObject);

		this.scoreLabel.enabled = false;
		this.livesLabel.enabled = false;
		this.gameOverLabel.enabled = true; // Makes game over, final score, restart text appear when game ends 
		this.finalScoreLabel.enabled = true;
		this.restartLabel.enabled = true;
		this.finalScoreLabel.text = "Score: " + this.scoreValue;




	}

	
}