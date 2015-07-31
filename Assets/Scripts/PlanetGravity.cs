using UnityEngine;
using System.Collections;

public class PlanetGravity : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	//Strength of attraction from your sphere (obviously, it can be any type of game-object)
	float basePull = 120;

	GameObject player;
	
	//Obviously, you won't be using planets, so change this variable to whatever you want
	//Use FixedUpdate because we are controlling the orbit with physics
	void FixedUpdate () 
	{
		float StrengthOfAttraction = basePull * transform.localScale.x;
		player = GameObject.FindGameObjectWithTag("Player");
		if (player)
		{
			var distance = Vector3.Distance(transform.position, player.transform.position);
			if (distance < 50)
			{	
				//Declare Variables:
				//magsqr will be the offset squared between the object and the planet
				float magsqr;
				//offset is the distance to the planet
				Vector3 offset;
				//get offset between each planet and the player
				offset = transform.position - player.transform.position;
				//My game is 2D, so  I set the offset on the Z axis to 0
				offset.z = 0;
				//Offset Squared:
				magsqr = offset.sqrMagnitude;
				//Check distance is more than 0 to prevent division by 0
				if (magsqr > 0.0001f)
				{
					//Create the gravity- make it realistic through division by the "magsqr" variable
					player.GetComponent<Rigidbody2D>().AddForce((StrengthOfAttraction * offset.normalized / magsqr) * player.GetComponent<Rigidbody2D>().mass);
				}	
			}
			
		}
		
		
	}

}
