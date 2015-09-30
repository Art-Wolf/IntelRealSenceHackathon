using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Text strikeText;

	public Text scoreText;
	public Text timeText;

	public GameObject player;

	public GameObject ball;


	public GameObject pin1;
	public GameObject pin2;
	public GameObject pin3;
	public GameObject pin4;
	public GameObject pin5;
	public GameObject pin6;
	public GameObject pin7;
	public GameObject pin8;
	public GameObject pin9;
	public GameObject pin10;

	public GameObject bowlingSystem;

	public int score = 0;
	public float turnTime = 10f;

	private int turn = 1;

	private GameObject [] pinArray = new GameObject[10];
	private Quaternion [] qutArray = new Quaternion[10];
	// Use this for initialization

	void Start () {
		pinArray [0] = pin1;
		pinArray [1] = pin2;
		pinArray [2] = pin3;
		pinArray [3] = pin4;
		pinArray [4] = pin5;
		pinArray [5] = pin6;
		pinArray [6] = pin7;
		pinArray [7] = pin8;
		pinArray [8] = pin9;
		pinArray [9] = pin10;

		qutArray[0] = pin1.transform.rotation;
		qutArray[1] = pin2.transform.rotation;
		qutArray[2] = pin3.transform.rotation;
		qutArray[3] = pin4.transform.rotation;
		qutArray[4] = pin5.transform.rotation;
		qutArray[5] = pin6.transform.rotation;
		qutArray[6] = pin7.transform.rotation;
		qutArray[7] = pin8.transform.rotation;
		qutArray[8] = pin9.transform.rotation;
		qutArray[9] = pin10.transform.rotation;

		scoreText.text = "Score: " + score;
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKey (KeyCode.R)) {
			Application.LoadLevel (0);
		}

		int currentFrame = bowlingSystem.GetComponent<BowlingController>().currentFrame;

		if (turnTime < 8 && score == 10) {
			strikeText.text = "";
			bowlingSystem.GetComponent<BowlingController>().score[currentFrame + 1] = score;
			bowlingSystem.GetComponent<BowlingController>().currentFrame = currentFrame + 1;
			Application.LoadLevel(0);
		}

		if (turnTime > 0) {
			turnTime -= Time.deltaTime;

			timeText.text = "Time remaining: " + turnTime;
		}

		if (turnTime <= 0) {
			score = 0;

			for (int i = 0; i < 10; i++) {
				if (pinArray[i] != null) { 
					pinArray[i].GetComponent<Rigidbody>().isKinematic = true;
					float pinDiff = Quaternion.Angle(pinArray[i].transform.rotation, qutArray[i]);
					if (pinDiff > 1 ) { 
						score = score + 1; 
						GameObject.Destroy(pinArray[i]);
					}
				}
			}

			scoreText.text = "Score: " + score;

			ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
			ball.GetComponent<Rigidbody>().isKinematic = true;
			ball.transform.position = new Vector3(4.6797f, -0.62f, -1.125f);
			ball.GetComponent<Rigidbody>().isKinematic = false;

			player.GetComponent<GrabAndDrop>().held = 0;
			player.GetComponent<GrabAndDrop>().grabbedObject = ball;

			for (int i = 0; i < 10; i++) {
				if (pinArray[i] != null) { 
					pinArray[i].GetComponent<Rigidbody>().isKinematic = false;
				}
			}

			if (turn == 1 && score == 10) {
				strikeText.text = "STRIKE!!!";
			}

			turn++;
			turnTime = 10f;



			if ( turn == 2 ) {
				bowlingSystem.GetComponent<BowlingController>().score[currentFrame] = score;
			} else {
				bowlingSystem.GetComponent<BowlingController>().score[currentFrame + 1] = score;
			}

			if (turn > 2) {
				bowlingSystem.GetComponent<BowlingController>().currentFrame = currentFrame + 1;
				Application.LoadLevel(0);
			}
		}
	}
}
