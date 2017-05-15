using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MeteorPhysics : MonoBehaviour {
	[SerializeField] private GameObject hitMeteorPrefab;
	private GameObject gravityCentre;

	void Start () {
		gravityCentre = GameObject.Find ("Planet");
	}

	void Update () {
		GetComponent<Rigidbody>().AddForce((gravityCentre.transform.position - transform.position).normalized * 25f);
	}

	void OnCollisionEnter (Collision hit) {
		if (hit.gameObject.tag == "Planet") {
			GetComponent<Rigidbody> ().detectCollisions = false;
			GetComponent<Rigidbody> ().isKinematic = true;
			SwitchModel ();
		}
	}

	void SwitchModel () {
		Destroy (gameObject);
		Instantiate(hitMeteorPrefab, transform.position, Quaternion.FromToRotation (Vector3.forward, transform.position - gravityCentre.transform.position));
	}
}
