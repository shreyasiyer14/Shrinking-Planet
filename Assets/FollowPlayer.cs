using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FollowPlayer : MonoBehaviour {

	[SerializeField] private Transform playerModel;
	void Start () {
		
	}

	void Update () {
		transform.LookAt (playerModel);
	}
}
