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
		Time.timeScale = 0.1f * Time.unscaledDeltaTime;
		Time.timeScale = Mathf.Clamp (Time.timeScale, 0f, 1f);
		Time.fixedDeltaTime = 0.02f * Time.timeScale;
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
		//Y and Z parameters for the Quaternion will remain the same throughout, only the X parameter changes.
		transform.RotateAround(planet.position, Vector3.up, speed * 100f * Time.fixedDeltaTime);
	}
}
