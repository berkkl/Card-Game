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
    
    public void ChangePopulation(float deltaPopulation)
    {
        this.PopulationData.ChangePopulation(deltaPopulation);
    }
    
    public void ChangeHappiness(float deltaHappiness)
    {
        this.PopulationData.ChangeHappiness(deltaHappiness);
    }
    
    public void ChangeHealthcare(float deltaHealthcare)
    {
        this.PopulationData.ChangeHealthcare(deltaHealthcare);
    }

    #endregion
}
