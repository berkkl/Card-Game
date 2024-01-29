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
    /// Updates the economy by applying changes to money, inflation, and production.
    /// </summary>
    /// <param name="deltaMoney">The change in money value.</param>
    /// <param name="deltaInflation">The change in inflation value.</param>
    /// <param name="deltaProduction">The change in production value.</param>
    public void UpdateEconomy(float deltaMoney = 0f, float delftaInflation = 0f, float deltaProduction = 0f)
    {
        EconomyData.ChangeMoney(deltaMoney);
        EconomyData.ChangeInflation(delftaInflation);
        EconomyData.ChangeProduction(deltaProduction);
    }
    #endregion methods
}