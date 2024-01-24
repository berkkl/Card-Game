using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentManager : MonoBehaviour
{
    public static EnvironmentManager Instance { get; private set; }
    public EnvironmentData EnvironmentData { get; private set; }
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            EnvironmentData = new EnvironmentData();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    #region methods
    
    public void ChangePollution(float deltaPollution)
    {
        EnvironmentData.ChangePollution(deltaPollution);
    }
    
    public void ChangeNaturalResources(float deltaNaturalResources)
    {
        EnvironmentData.ChangeNaturalResources(deltaNaturalResources);
    }

    #endregion
}
