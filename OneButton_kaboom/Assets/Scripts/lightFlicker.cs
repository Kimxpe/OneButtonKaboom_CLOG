using UnityEngine;
using System.Collections;

public class lightFlicker : MonoBehaviour {

	public float flickerInterval = 0.01f;
	public float minLightLevel = 0.45f;
	public float maxLightLevel = 0.75f;

	private float randomRange;
	private float flickerTimer;
	private Light theLight;

	void Start() {

		if (minLightLevel > maxLightLevel) {
			// If the user entered a value for the minimum light level
			// that is higher than the maximum light level, let's go
			// ahead and switch them around.

			float tmpLightLevel = minLightLevel;
			minLightLevel = maxLightLevel;
			maxLightLevel = tmpLightLevel;
		}

		if (minLightLevel < 0) {
			Debug.LogWarning("Warning: Light level specified less than zero. Making it zero.");
			minLightLevel = 0.00f;
		}
		if (maxLightLevel < 0) {
			Debug.LogWarning("Warning: Light level specified less than zero. Making it zero.");
			maxLightLevel = 0.00f;
		}
		randomRange = maxLightLevel - minLightLevel;

		theLight = this.gameObject.GetComponent<Light>();

		// Set the light to an acceptable value. This ignores the defaults
		// from the light component in the editor.
		theLight.intensity = (Random.value * randomRange) + minLightLevel;

		// Set the last flicker time to right now.
		flickerTimer = Time.time;
	}

	void Update() {
		if (Time.time > flickerTimer + flickerInterval) {
			// If the appropriate amount of time has passed, change the
			// intensity of the light...
			theLight.intensity = (Random.value * randomRange) + minLightLevel;

			// ... and set the timer back to right now.
			flickerTimer = Time.time;
		}
	}
}
