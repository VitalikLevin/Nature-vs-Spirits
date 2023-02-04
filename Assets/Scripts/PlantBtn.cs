using UnityEngine;
using UnityEngine.UI;
public class PlantBtn : MonoBehaviour
{
	[SerializeField]
	private GameObject plantPrefab;
	[SerializeField]
	private Sprite sprite;
	[SerializeField]
	private int price;
	[SerializeField]
	private Text priceText;
	public int Price
    {
        get
        {
            return price;
        }
    }
	public GameObject PlantPrefab
	{
		get
		{
			return plantPrefab;
		}
	}
	public Sprite SpriTe
	{
		get
		{
			return sprite;
		}
	}
    private void Start ()
	{
		priceText.text = Price.ToString();
	}
}