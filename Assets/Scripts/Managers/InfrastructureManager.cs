using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfrastructureManager : MonoBehaviour
{
    public static InfrastructureManager Instance { get; private set; }
    public InfrastructureData InfrastructureData { get; private set; }
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            InfrastructureData = new InfrastructureData();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    #region MyRegion
    
    public void ChangeInfrastructure(float deltaInfrastructure)
    {
        this.InfrastructureData.ChangeInfrastructure(deltaInfrastructure);
    }
    
    public void ChangeEducation(float deltaEducation)
    {
        this.InfrastructureData.ChangeEducation(deltaEducation);
    }
    
    public void ChangeResearch(float deltaResearch)
    {
        this.InfrastructureData.ChangeResearch(deltaResearch);
    }
    
    #endregion
}
