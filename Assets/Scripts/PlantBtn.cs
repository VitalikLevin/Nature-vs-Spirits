using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantBtn : Singleton<PlantBtn> 
{
	[SerializeField]
	private GameObject pickedPlant;
	public GameObject PickedPlant
	{
		get
		{
			return pickedPlant;
		}
	}
	public void PickPlant ()
	{
		PlantSet.Instance.PlantPrefab = PickedPlant;
	}
}
