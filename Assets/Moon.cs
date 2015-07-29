using UnityEngine;
using System.Collections;

public class Moon : MonoBehaviour {

	GameObject cube;
	public Transform center;
	public Vector3 axis = Vector3.up;
	public Vector3 desiredPosition;
	public float radius = 5.0f;
	public float radiusSpeed = 0.5f;
	public float rotationSpeed = 80.0f;
	public GameObject planet;
	
	void Start () {
		center = planet.transform;
		transform.position = (transform.position - center.position).normalized * radius + center.position;
	}
	
	void Update () {
		transform.RotateAround (center.position, axis, rotationSpeed * Time.deltaTime);
		desiredPosition = (transform.position - center.position).normalized * radius + center.position;
		transform.position = Vector3.MoveTowards(transform.position, desiredPosition, Time.deltaTime * radiusSpeed);
	}
}
