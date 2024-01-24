using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentData : MonoBehaviour
{
    public float pollution { get; private set; }
    public float naturalResources { get; private set; }

    public EnvironmentData()
    {
        this.pollution = 0;
        this.naturalResources = 0;
    }
    
    public EnvironmentData(float pollution, float naturalResources)
    {
        this.pollution = pollution;
        this.naturalResources = naturalResources;
    }
    
    public void ChangePollution(float deltaPollution)
    {
        this.pollution += deltaPollution;
    }
    
    public void ChangeNaturalResources(float deltaNaturalResources)
    {
        this.naturalResources += deltaNaturalResources;
    }
}
