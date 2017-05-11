using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MeteorPhysics : MonoBehaviour {

	private GameObject gravityCentre;

	void Start () {
		gravityCentre = GameObject.Find ("Planet");
	}

	void Update () {
		GetComponent<Rigidbody>().AddForce((gravityCentre.transform.position - transform.position).normalized * 25f);
	}
}
