using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulationData : MonoBehaviour
{
    public float Population { get; private set; }
    public float Happiness { get; private set; }
    public float Healthcare { get; private set; }

    public PopulationData()
    {
        this.Population = 0;
        this.Happiness = 0;
        this.Healthcare = 0;
    }

    public PopulationData(float population, float happiness, float healthcare)
    {
        this.Population = population;
        this.Happiness = happiness;
        this.Healthcare = healthcare;
    }
    
    public void ChangePopulation(float deltaPopulation)
    {
        this.Population += deltaPopulation;
    }

    public void ChangeHappiness(float deltaHappiness)
    {
        this.Happiness += deltaHappiness;
    }

    public void ChangeHealthcare(float deltaHealthcare)
    {
        this.Healthcare += deltaHealthcare;
    }
}
