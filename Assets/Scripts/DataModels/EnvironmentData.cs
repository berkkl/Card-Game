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
    /// <summary>
    /// Represents the level of pollution in the environment. This could include various forms such as
    /// air, water, soil, or noise pollution. Higher values could symbolize a more polluted environment.
    /// </summary>
    public void ChangePollution(float deltaPollution)
    {
        this.pollution += deltaPollution;
    }
    /// <summary>
    /// Represents the abundance and quality of natural resources available in an environment.
    /// This could involve aspects like forests, minerals, oil reserves, fertile lands for agriculture,
    /// water bodies, and other such environmental assets.
    /// </summary>
    public void ChangeNaturalResources(float deltaNaturalResources)
    {
        this.naturalResources += deltaNaturalResources;
    }
}
