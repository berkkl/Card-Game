using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EconomyManager : MonoBehaviour
{
	public static EconomyManager Instance { get; private set; }
	public EconomicData EconomyData { get; private set; }

	void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
			EconomyData = new EconomicData();
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}

	#region methods
	/// <summary>
	/// Updates Money
	/// </summary>
	/// <param name="deltaMoney"></param>
	public void UpdateEconomy(float deltaMoney)
	{
		EconomyData.Money += deltaMoney;
		// Additional logic to update economy
	}
	#endregion methods
}
