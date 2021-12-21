using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour {

    float nRand = 0;
    public float flickerIntensity = 0.1f;
    public float flickersPerSecond = 3.0f;
    public float speedRandomness = 1.0f;

    private float time;
    private float startingIntensity;
	
    void Start()
    {
        startingIntensity = this.transform.GetComponent<Light>().intensity;
    }

	void Update ()
    {
        nRand = Random.RandomRange(-0.2f, 0.2f);
        time += Time.deltaTime * (1 - Random.Range(-speedRandomness, speedRandomness)) * Mathf.PI;
        this.transform.GetComponent<Light>().intensity = startingIntensity + Mathf.Sin(time * flickersPerSecond) * flickerIntensity * nRand;
        this.transform.GetComponent<Transform>().position = new Vector3(2.5f, 0.5f, 0.1f + nRand * flickerIntensity);
        //light.intensity = startingIntensity + Mathf.Sin(time * flickersPerSecond) * flickerIntensity;
	}
}
