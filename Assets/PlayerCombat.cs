using UnityEngine;
using System.Collections;

public class PlayerCombat : MonoBehaviour {
	public GameObject machine;
	public GameObject grenade;
	public GameObject sniper;
	public Transform shotSpawn; //shotSpawn.transform.plat
	public float fireRate;
	public float fireRate2;
	public float fireRate3;
	private float nextFire;
	private float nextFire2;
	private float nextFire3;

	// Use this for initialization
	void Start () {
	
	}

	void Update()
	{
		bool lMouse = Input.GetButton ("Fire1");
		bool rMouse = Input.GetButton ("Fire2");
		
		
		if (lMouse && Time.time > nextFire && !rMouse) 
		{
			nextFire = Time.time + fireRate;
			Instantiate(machine, shotSpawn.position, shotSpawn.rotation);// as GameObject;
		}
		if (rMouse && Time.time > nextFire2 && !lMouse) 
		{
			nextFire2 = Time.time + fireRate2;
			Instantiate(grenade, shotSpawn.position, shotSpawn.rotation);// as GameObject;
		}
		if (rMouse && lMouse && Time.time > nextFire3) 
		{
			nextFire3 = Time.time + fireRate3;
			Instantiate(sniper, shotSpawn.position, shotSpawn.rotation);// as GameObject;
		}
	}
}
