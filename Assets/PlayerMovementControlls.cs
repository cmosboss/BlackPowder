using UnityEngine;
using System.Collections;

public class PlayerMovementControlls : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
		if(GetComponent<Rigidbody2D>().velocity.magnitude > 100)
		{
			GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity.normalized * 100;
		}
		if (Input.GetKey("up"))
		{
			if (GetComponent<Rigidbody2D>().velocity.magnitude < 100 / 3)
			{
				GetComponent<Rigidbody2D>().AddForce(transform.up * 10);
			}else
			{
				GetComponent<Rigidbody2D>().AddForce(transform.up * 10);
			}
		}
		if (Input.GetKey("left"))
		{
			transform.Rotate(0F, 0F, 5);
		}
		if (Input.GetKey("right"))
		{
			transform.Rotate(0F, 0F, -5);
		}
		if (Input.GetKey("down"))
		{
			GetComponent<Rigidbody2D>().velocity = Vector2.Lerp(GetComponent<Rigidbody2D>().velocity, Vector2.zero, 0.25f);
		}
	}
	//Public Vars
	public Camera camera;
	public float speed;
	
	//Private Vars
	private Vector3 mousePosition;
	private Vector3 direction;
	private float distanceFromObject;
	
	void FixedUpdate() {
			//Grab the current mouse position on the screen
			mousePosition = camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y, Input.mousePosition.z - camera.transform.position.z));
			//Rotates toward the mouse
			transform.eulerAngles = new Vector3(0,0,Mathf.Atan2((mousePosition.y - transform.position.y), (mousePosition.x - transform.position.x))*Mathf.Rad2Deg - 90);
			//Judge the distance from the object and the mouse
			distanceFromObject = (Input.mousePosition - camera.WorldToScreenPoint(transform.position)).magnitude;
			//Move towards the mouse
			GetComponent<Rigidbody2D>().AddForce(direction * speed * distanceFromObject * Time.deltaTime);
	}//End Fire3 If case

}
