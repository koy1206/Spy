﻿using UnityEngine;
using System.Collections;

public class ArrowGenerator : MonoBehaviour {


	public GameObject arrowPrefab;
	float span = 0.1f;
	float delta = 0;

	void Update() {
		this.delta += Time.deltaTime;
		if(this.delta > this.span) {
			this.delta = 0;
			GameObject go = Instantiate(arrowPrefab) as GameObject;
			int px = Random.Range(-6, 7);
			go.transform.position = new Vector3(px, 7, 0);
		}
	}
}