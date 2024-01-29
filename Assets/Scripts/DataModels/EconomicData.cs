using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EconomicData
{
    public float Money { get; private set; }
    public float Inflation { get; private set; }
    public float Production { get; private set; }

    public EconomicData()
    {
        this.Money = 0;
        this.Inflation = 0;
        this.Production = 0;
    }

    public EconomicData(float money, float inflation, float production)
    {
        this.Money = money;
        this.Inflation = inflation;
        this.Production = production;
    }
    
    /// <summary>
    /// Represents the total economic wealth or financial resources available within a country.
    /// This could encompass industry earnings, revenues from taxes, and other sources of national income.
    /// </summary>
    public void ChangeMoney(float deltaMoney)
    {
        this.Money += deltaMoney;
    }

    /// <summary>
    /// Represents the rate at which the general level of prices for goods and services is rising and subsequently, purchasing power is falling. 
    /// It's a key indicator of economic health where a moderate level is generally viewed as positive.
    /// </summary>
    public void ChangeInflation(float deltaInflation)
    {
        Inflation += deltaInflation;
    }

    /// <summary>
    /// Represents the total goods and services produced within a country over a specific period. 
    /// It can be seen as a primary indicator of the country's economic health.
    /// </summary>
    public void ChangeProduction(float deltaProduction)
    {
        Production += deltaProduction;
    }
}
