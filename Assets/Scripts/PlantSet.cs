using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantSet : MonoBehaviour 
{
	[SerializeField]
	private GameObject plant;
	[SerializeField]
	private Transform grass;
	private void SetPlant ()
	{
		GameObject NewPlant = Instantiate (plant);
		NewPlant.transform.position = new Vector3 (grass.position.x, grass.position.y, 0);
		NewPlant.transform.SetParent (grass);
	}
	private void BuyPlant ()
	{
		plant = null;
	}
	void OnMouseUp () 
	{
		SetPlant ();
		BuyPlant ();
	}
	void Start ()
	{
		grass = GetComponent<Transform> ();
	}
}