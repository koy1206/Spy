using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

public float hp = 0.1f;
public Text timeText;
GameObject hpGage;
float elapsedTime;

void Start() {
	this.hpGage = GameObject.Find("hpGage");
}
	public void DecreaseHp() {
		this.hpGage.GetComponent<Image> ().fillAmount -= hp;
	}
	
	void Update()
	{
		elapsedTime += Time.deltaTime;
		timeText.text = "시간:" + elapsedTime;
	}
}