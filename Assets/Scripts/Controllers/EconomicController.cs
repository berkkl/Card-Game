using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EconomicController : MonoBehaviour
{
	// add methods to get player inputs
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.E))
		{
			// Example of player triggering economic update
			EconomyManager.Instance.UpdateMoney(100);
		}
	}
}
