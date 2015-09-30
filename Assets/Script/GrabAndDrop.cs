using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GrabAndDrop : MonoBehaviour {
	
	public GameObject grabbedObject;
	float grabbedObjectSize;
	private GameObject PalmCenterPrefab;
	private Vector3 lastVelocity;
	private int held = 0;
	private bool pressed = false;

	GameObject GetMouseHoverObject(float range)
	{
		Vector3 position = gameObject.transform.position;
		RaycastHit raycastHit;
		Vector3 target = position + Camera.main.transform.forward * range;
		
		if (Physics.Linecast(position, target, out raycastHit))
			return raycastHit.collider.gameObject;
		return null;
		
	}
	
	void TryGrabObject(GameObject grabObject)
	{
		if (grabObject == null || !CanGrab(grabObject))
			return;
		grabbedObject = grabObject;
		grabbedObjectSize = grabObject.GetComponent<Renderer>().bounds.size.magnitude;
	}
	bool CanGrab(GameObject canidate)
	{
		return canidate.GetComponent<Rigidbody>() != null;
	}
	void DropObject()
	{
		if (grabbedObject == null)
			return;
		
		
		//if (grabbedObject.GetComponent<Rigidbody> () != null)
			//grabbedObject.GetComponent<Rigidbody> ().velocity = Vector3.zero;
			grabbedObject.GetComponent<Rigidbody>().AddForce(lastVelocity * -100);
		grabbedObject = null;
	}
	
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			if (PalmCenterPrefab == null) {
				PalmCenterPrefab = GameObject.FindGameObjectWithTag ("palm");
			}
			//	if (grabbedObject == null)
			//		TryGrabObject(GetMouseHoverObject(5));
			//	else
			//		DropObject();
			//}
		
			if (grabbedObject != null) {
				Vector3 newPosition = PalmCenterPrefab.transform.position + Camera.main.transform.forward * grabbedObjectSize;
				grabbedObject.transform.position = newPosition;
				lastVelocity = newPosition;
			}

			held = 1;
			pressed = true;
		} else {
			pressed = false;
		}

		if (!pressed && held == 1) {
		//	held = 2;
//		}

//		if (held == 2) {
			DropObject ();
		}
		
	}
}