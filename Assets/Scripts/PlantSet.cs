using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantSet : Singleton<PlantSet>
{
	private GameObject plantPrefab;
	public GameObject PlantPrefab
	{
		get
		{
			return plantPrefab;
		}
		set
		{
			this.plantPrefab = value;
		}
	}
	private Transform grass;
	private void PlacePlant ()
	{
		GameObject NewPlant = Instantiate (PlantPrefab);
		NewPlant.transform.position = new Vector3 (grass.position.x, grass.position.y, 0);
		NewPlant.transform.SetParent (grass);
	}
	private void BuyPlant ()
	{
		plantPrefab = null;
	}
	void OnMouseDown () 
	{
		PlacePlant ();
		BuyPlant ();
	}
	void Start ()
	{
		grass = GetComponent<Transform> ();
	}
}