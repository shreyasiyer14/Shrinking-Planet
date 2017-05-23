using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	[SerializeField] private Transform planet;
	[SerializeField] private GameObject UX;
	[SerializeField] private float reductionFactor;
	void Update () {
		ReducePlanetScale ();
		Debug.Log ("Score: " +  planet.localScale + "m");
	}

	void ReducePlanetScale () {
		planet.localScale = new Vector3 (planet.localScale.x - reductionFactor * Time.fixedDeltaTime, planet.localScale.y - reductionFactor * Time.fixedDeltaTime, planet.localScale.z - reductionFactor * Time.fixedDeltaTime);
	}
}
