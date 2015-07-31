using UnityEngine;
using System.Collections;

public class ParralaxFollow : MonoBehaviour {
	public GameObject parralaxCamera;

	// Use this for initialization
	void Start () {
	 
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 offset = parralaxCamera.transform.position;
		
		offset.x = (offset.x / 2)+25;
		offset.y = offset.y / 2;
		offset.z = 10;
		
		transform.position = offset;
	}
}
