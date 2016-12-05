using UnityEngine;
using System.Collections;

public class Rotation2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.left);
		transform.Rotate (Vector3.down);

	}
}
