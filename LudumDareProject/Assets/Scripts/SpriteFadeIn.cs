using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Josh

public class SpriteFadeIn : MonoBehaviour {

	public float fadeStart = 2;
	public float fadeLength = 1;

	SpriteRenderer sr;

	float timeStart = 0;

	// Start is called before the first frame update
	void Start() {
		sr = GetComponent<SpriteRenderer>();
		timeStart = Time.time;
	}

	// Update is called once per frame
	void Update() {
		float alpha = 0;
		float time = Time.time - timeStart;
		if(time < fadeStart) {
			alpha = 0;
		} else {
			alpha = ((time - fadeStart) / fadeLength);
		}
		sr.color = new Vector4(1, 1, 1, alpha);
	}
}
