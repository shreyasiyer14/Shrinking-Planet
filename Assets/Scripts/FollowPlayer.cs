using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FollowPlayer : MonoBehaviour {

	[SerializeField] private Transform playerModel;
	[SerializeField] private float speed;
	void Start () {
		
	}

	void Update () {
		transform.LookAt (playerModel);
		CameraMotion ();
	}

	void CameraMotion () {
		//transform.position = new Vector3 ();
	}
}
