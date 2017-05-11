using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Meteor : MonoBehaviour {
	[SerializeField] private float timeForSpawn;
	[SerializeField] private GameObject meteor;
	[SerializeField] private float spawningRadius;

	void Start () {
		InvokeRepeating ("spawnMeteor", 0.1f, timeForSpawn);
	}
	
	void spawnMeteor () {
		Vector3 pos = Random.onUnitSphere * spawningRadius;
		//Quaternion rot = Quaternion.FromToRotation (Vector3.forward, transform.position - pos);
		Instantiate (meteor, pos, Quaternion.identity);
	}
}
