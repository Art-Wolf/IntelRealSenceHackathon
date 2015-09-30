using UnityEngine;
using System;
using System.Collections;

public class GameManager : MonoBehaviour {

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

	private Vector3 pin1Position;
	private Vector3 pin2Position;
	private Vector3 pin3Position;
	private Vector3 pin4Position;
	private Vector3 pin5Position;
	private Vector3 pin6Position;
	private Vector3 pin7Position;
	private Vector3 pin8Position;
	private Vector3 pin9Position;
	private Vector3 pin10Position;

	// Use this for initialization
	void Start () {
		pin1Position = pin1.transform.position;
		pin2Position = pin2.transform.position;
		pin3Position = pin3.transform.position;
		pin4Position = pin4.transform.position;
		pin5Position = pin5.transform.position;
		pin6Position = pin6.transform.position;
		pin7Position = pin7.transform.position;
		pin8Position = pin8.transform.position;
		pin9Position = pin9.transform.position;
		pin10Position = pin10.transform.position;

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
			Vector3 pin1Diff = pin1.transform.position - pin1Position;

			if (pin1Diff != Vector3.zero && (Math.Round (pin1.transform.rotation.x) != 0 || Math.Round (pin1.transform.rotation.x) != 0 )) { score = score + 1; GameObject.Destroy(pin1);}
			//if (pin2.transform.position != pin2Position &&(pin2.transform.rotation.x != 0 || pin2.transform.rotation.z != 0 )) {score = score + 1; GameObject.Destroy(pin2);}
			//if (pin3.transform.position != pin3Position &&(pin3.transform.rotation.x != 0 || pin3.transform.rotation.z != 0 )) {score = score + 1; GameObject.Destroy(pin3);}
			//if (pin4.transform.position != pin4Position &&(pin4.transform.rotation.x != 0 || pin4.transform.rotation.z != 0 )) {score = score + 1; GameObject.Destroy(pin4);}
			//if (pin5.transform.position != pin5Position &&(pin5.transform.rotation.x != 0 || pin5.transform.rotation.z != 0 )) {score = score + 1; GameObject.Destroy(pin5);}
			//if (pin6.transform.position != pin6Position &&(pin6.transform.rotation.x != 0 || pin6.transform.rotation.z != 0 )) {score = score + 1; GameObject.Destroy(pin6);}
			//if (pin7.transform.position != pin7Position &&(pin7.transform.rotation.x != 0 || pin7.transform.rotation.z != 0 )) {score = score + 1; GameObject.Destroy(pin7);}
			//if (pin8.transform.position != pin8Position &&(pin8.transform.rotation.x != 0 || pin8.transform.rotation.z != 0 )) {score = score + 1; GameObject.Destroy(pin8);}
			//if (pin9.transform.position != pin9Position &&(pin9.transform.rotation.x != 0 || pin9.transform.rotation.z != 0 )) {score = score + 1; GameObject.Destroy(pin9);}
			//if (pin10.transform.position != pin10Position &&(pin10.transform.rotation.x != 0 || pin10.transform.rotation.z != 0 )) {score = score + 1; GameObject.Destroy(pin10);}
		}
	}
}
