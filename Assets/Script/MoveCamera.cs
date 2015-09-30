using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

	public float speed = 1.5f;

	private float lastMousePosition = 0;

	void Start () {
		lastMousePosition = Input.GetAxis ("Mouse Y");
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (new Vector3 (speed * Time.deltaTime, 0, 0));
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (new Vector3 (-speed * Time.deltaTime, 0, 0));
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (new Vector3 (0, -speed * Time.deltaTime, 0));
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (new Vector3 (0, speed * Time.deltaTime, 0));
		}

		float newMousePosition = Input.GetAxis ("Mouse Y");
		if (newMousePosition != lastMousePosition) {
			transform.Translate(new Vector3(0.0f, 0.0f, newMousePosition));
		} 

	}
}
