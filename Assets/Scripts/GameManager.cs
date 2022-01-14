using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager> 
{
	public PlantBtn ClickedBtn { get; set; }
	private int currency;
	[SerializeField]
	private int bonus;
	[SerializeField]
	private Text currencyText;
	public int Currency
	{
		get
		{
			return currency;
		}
		set
		{
			this.currency = value;
			this.currencyText.text = value.ToString();
		}
	}
	public void PickPlant (PlantBtn plantBtn) 
	{
		if (Currency >= plantBtn.Price)
		{
			this.ClickedBtn = plantBtn;
			Hover.Instance.Activate(plantBtn.SpriTe);
		}
	}
	public void BuyPlant()
	{
		if (Currency >= ClickedBtn.Price)
		{
			Currency -= ClickedBtn.Price;
			Hover.Instance.Deactivate();
		}
	}
	private void HandleEscape ()
	{
		if (Input.GetKeyDown(KeyCode.Escape) || Input.GetMouseButton(1))
		{
			Hover.Instance.Deactivate();
		}
	}
	void Update ()
	{
		HandleEscape();
	}
	void Start ()
	{
		Currency = 50 + bonus;
	}
}