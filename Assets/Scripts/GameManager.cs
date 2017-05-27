using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	[SerializeField] private Transform planet;
	[SerializeField] private GameObject UX;
	[SerializeField] private float reductionFactor;
	void Update () {
		ReducePlanetScale ();
		UX.GetComponent<Text> ().text = planet.localScale.x.ToString() + "m";
	}

	void ReducePlanetScale () {
		planet.localScale -= Vector3.one * Time.fixedDeltaTime * reductionFactor;
	}
}
