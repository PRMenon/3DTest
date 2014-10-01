using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour {
	public int rate;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (rate * (Vector3.left + 0.5f * Vector3.up)*Time.deltaTime);
	}
}
