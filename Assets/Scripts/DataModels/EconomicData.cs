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

    public void ChangeMoney(float deltaMoney)
    {
        this.Money += deltaMoney;
    }

    public void ChangeInflation(float deltaInflation)
    {
        Inflation += deltaInflation;
    }

    public void ChangeProduction(float deltaProduction)
    {
        Production += deltaProduction;
    }
}
