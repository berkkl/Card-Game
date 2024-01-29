using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulationManager : MonoBehaviour
{
    public static PopulationManager Instance { get; private set; }
    public PopulationData PopulationData { get; private set; }
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            PopulationData = new PopulationData();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    #region methods

    /// <summary>
    /// Updates the population with the changes in population, happiness, and healthcare.
    /// </summary>
    /// <param name="deltaPopulation">The change in population.</param>
    /// <param name="deltaHappiness">The change in happiness.</param>
    /// <param name="deltaHealthcare">The change in healthcare.</param>
    public void UpdatePopulation(float deltaPopulation = 0f, float deltaHappiness = 0f, float deltaHealthcare = 0f)
    {
        PopulationData.ChangePopulation(deltaPopulation);
        PopulationData.ChangeHappiness(deltaHappiness);
        PopulationData.ChangeHealthcare(deltaHealthcare);
    }
    
    #endregion
}
