using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {
	
	private Vector3 correctPlayerPos;
	private Quaternion correctPlayerRot;
	void update()
	{
		Vector3 pos = transform.position;
		pos.z = 0;
		transform.position = pos;
	}
	public float speed = 100;
	void Start()
	{
		GetComponent<Rigidbody2D>().velocity = ((Vector2)transform.up * speed)+ GetComponent<Rigidbody2D>().velocity;

		Vector3 temp = GetComponent<Rigidbody2D>().velocity;
		temp.z = 0;
		GetComponent<Rigidbody2D>().velocity = temp;
	}
}
