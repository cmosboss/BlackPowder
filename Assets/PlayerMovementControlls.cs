using UnityEngine;
using System.Collections;

public class PlayerMovementControlls : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			Debug.Log("SPACE");
			gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(100,0));
		}
	}
}
