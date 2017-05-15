using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
	[SerializeField] private float speed;
	[SerializeField] private float turnFactor;
	[SerializeField] private Transform planet;

	void Start () {
		
	}
	
	void Fixedupdate () {

	}

	void Update () {
		RotateAroundPlanet ();

		#region INPUT_MANAGER
		if (Input.GetKey(KeyCode.D))
			transform.Rotate (new Vector3 (turnFactor, 0f, 0f));

		if (Input.GetKey(KeyCode.A))
			transform.Rotate (new Vector3 (-turnFactor, 0f, 0f));
		#endregion
	}

	void RotateAroundPlanet () {
		transform.Translate (Vector3.forward * speed * Time.fixedDeltaTime);
		GetComponent<Rigidbody>().AddForce((planet.position - transform.position).normalized * turnFactor * 15f);
	}

	void OnCollisionEnter (Collision hit) {
		if (hit.gameObject.tag == "Meteor") {
			Debug.Log ("Game Over!");
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}
}
