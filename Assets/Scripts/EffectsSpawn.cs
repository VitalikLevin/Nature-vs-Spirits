using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsSpawn : MonoBehaviour
{
	///<summary>
	///Must have component "Particle System"
	///</summary>
    [SerializeField]
	private GameObject effects;
	[SerializeField]
	private bool effectsOn;
    void Start ()
    {
        CreateEffects ();
    }
    private void CreateEffects ()
	{
		if (effectsOn == true)
		{
			GameObject newEffect = Instantiate (effects);
			newEffect.transform.position = new Vector3 (10.3f, 7.2f, 1.5f);
			newEffect.transform.Rotate(180, 180, -169);
		}
	}
}