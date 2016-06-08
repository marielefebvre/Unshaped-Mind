﻿using UnityEngine;
using System.Collections;

public class StartScreen : MonoBehaviour {

	public int stratum;

	void Start () {
	}
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.Return)) {
			GetComponent<Animator>().Play("fadeOut");
			StartCoroutine("Deactivate");
		}
	}

	IEnumerator Deactivate() {
		yield return new WaitForSeconds(1.1f);
		Application.LoadLevel("Stratum" + stratum.ToString());
	}
}
