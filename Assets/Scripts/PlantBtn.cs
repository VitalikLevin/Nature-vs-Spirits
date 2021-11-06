using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantBtn : MonoBehaviour 
{
	public GameObject clickedPlant;
	private GameObject grass;
	//The custom plant
	public void clickedBtn () 
	{
		grass.GetComponent<PlantSet>().plant = clickedPlant;
	}
}
