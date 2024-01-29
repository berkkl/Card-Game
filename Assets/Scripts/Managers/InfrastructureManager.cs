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

    /// <summary>
    /// Updates the infrastructure and research data.
    /// </summary>
    /// <param name="deltaInfrastructure">The amount of change to apply to the infrastructure data. Default value is 0.</param>
    /// <param name="deltaResearch">The amount of change to apply to the research data. Default value is 0.</param>
    public void UpdateInfrastructure(float deltaInfrastructure = 0f, float deltaResearch = 0f)
    {
        InfrastructureData.ChangeInfrastructure(deltaInfrastructure);
        InfrastructureData.ChangeResearch(deltaResearch);
    }
    #endregion
}
