using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Text scoreText;

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

	public int score = 0;
	public float turnTime = 10f;

	private int turn = 1;

	private Quaternion pin1Position;
	private Quaternion pin2Position;
	private Quaternion pin3Position;
	private Quaternion pin4Position;
	private Quaternion pin5Position;
	private Quaternion pin6Position;
	private Quaternion pin7Position;
	private Quaternion pin8Position;
	private Quaternion pin9Position;
	private Quaternion pin10Position;

	// Use this for initialization
	void Start () {
		pin1Position = pin1.transform.rotation;
		pin2Position = pin2.transform.rotation;
		pin3Position = pin3.transform.rotation;
		pin4Position = pin4.transform.rotation;
		pin5Position = pin5.transform.rotation;
		pin6Position = pin6.transform.rotation;
		pin7Position = pin7.transform.rotation;
		pin8Position = pin8.transform.rotation;
		pin9Position = pin9.transform.rotation;
		pin10Position = pin10.transform.rotation;

		scoreText.text = "Score: " + score;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.R)) {
			Application.LoadLevel (0);
		}

		if (turnTime > 0) {
			turnTime -= Time.deltaTime;
		}

		if (turnTime <= 0) {
			pin1.GetComponent<Rigidbody>().velocity = Vector3.zero;
			pin2.GetComponent<Rigidbody>().velocity = Vector3.zero;
			pin3.GetComponent<Rigidbody>().velocity = Vector3.zero;
			pin4.GetComponent<Rigidbody>().velocity = Vector3.zero;
			pin5.GetComponent<Rigidbody>().velocity = Vector3.zero;
			pin6.GetComponent<Rigidbody>().velocity = Vector3.zero;
			pin7.GetComponent<Rigidbody>().velocity = Vector3.zero;
			pin8.GetComponent<Rigidbody>().velocity = Vector3.zero;
			pin9.GetComponent<Rigidbody>().velocity = Vector3.zero;
			pin10.GetComponent<Rigidbody>().velocity = Vector3.zero;

			pin1.GetComponent<Rigidbody>().isKinematic = true;
			pin2.GetComponent<Rigidbody>().isKinematic = true;
			pin3.GetComponent<Rigidbody>().isKinematic = true;
			pin4.GetComponent<Rigidbody>().isKinematic = true;
			pin5.GetComponent<Rigidbody>().isKinematic = true;
			pin6.GetComponent<Rigidbody>().isKinematic = true;
			pin7.GetComponent<Rigidbody>().isKinematic = true;
			pin8.GetComponent<Rigidbody>().isKinematic = true;
			pin9.GetComponent<Rigidbody>().isKinematic = true;
			pin10.GetComponent<Rigidbody>().isKinematic = true;

			float pin1Diff = Quaternion.Angle(pin1.transform.rotation, pin1Position);
			float pin2Diff = Quaternion.Angle(pin2.transform.rotation, pin2Position);
			float pin3Diff = Quaternion.Angle(pin3.transform.rotation, pin3Position);
			float pin4Diff = Quaternion.Angle(pin4.transform.rotation, pin4Position);
			float pin5Diff = Quaternion.Angle(pin5.transform.rotation, pin5Position);
			float pin6Diff = Quaternion.Angle(pin6.transform.rotation, pin6Position);
			float pin7Diff = Quaternion.Angle(pin7.transform.rotation, pin7Position);
			float pin8Diff = Quaternion.Angle(pin8.transform.rotation, pin8Position);
			float pin9Diff = Quaternion.Angle(pin9.transform.rotation, pin9Position);
			float pin10Diff = Quaternion.Angle(pin10.transform.rotation, pin10Position);

			Debug.Log(pin1Diff);

			if (pin1Diff > 1 ) { score = score + 1; if (pin1 != null) { GameObject.Destroy(pin1);}}
			if (pin2Diff > 1 ) { score = score + 1; if (pin2 != null) { GameObject.Destroy(pin2);}}
			if (pin3Diff > 1 ) { score = score + 1; if (pin3 != null) { GameObject.Destroy(pin3);}}
			if (pin4Diff > 1 ) { score = score + 1; if (pin4 != null) { GameObject.Destroy(pin4);}}
			if (pin5Diff > 1 ) { score = score + 1; if (pin5 != null) { GameObject.Destroy(pin5);}}
			if (pin6Diff > 1 ) { score = score + 1; if (pin6 != null) { GameObject.Destroy(pin6);}}
			if (pin7Diff > 1 ) { score = score + 1; if (pin7 != null) { GameObject.Destroy(pin7);}}
			if (pin8Diff > 1 ) { score = score + 1; if (pin8 != null) { GameObject.Destroy(pin8);}}
			if (pin9Diff > 1 ) { score = score + 1; if (pin9 != null) { GameObject.Destroy(pin9);}}
			if (pin10Diff > 1 ) { score = score + 1; if (pin10 != null) { GameObject.Destroy(pin10);}}

			scoreText.text = "Score: " + score;
		}
	}
}
