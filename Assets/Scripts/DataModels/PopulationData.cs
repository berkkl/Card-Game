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
    
    /// <summary>
    /// Represents the total number of people within a demographic location. This could also symbolize the overall size of a particular group in the simulation.
    /// </summary>
    public void ChangePopulation(float deltaPopulation)
    {
        this.Population += deltaPopulation;
    }
    /// <summary>
    /// Represents the overall satisfaction or happiness of the population. The factors contributing to happiness can vary and might include economic stability, job satisfaction, health, freedom, etc.
    /// </summary>
    public void ChangeHappiness(float deltaHappiness)
    {
        this.Happiness += deltaHappiness;
    }
    /// <summary>
    /// Represents the state of healthcare services in a particular area. 
    /// This can involve factors like overall health of the population, availability of medical services, health infrastructure, prevalence of diseases, etc.
    /// </summary>
    public void ChangeHealthcare(float deltaHealthcare)
    {
        this.Healthcare += deltaHealthcare;
    }
}
