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

    /// <summary>
    /// Updates the environment by changing the pollution and natural resources levels.
    /// </summary>
    /// <param name="deltaPollution">The change in pollution level. The default value is 0.</param>
    /// <param name="deltaNaturalResources">The change in natural resources level. The default value is 0.</param>
    public void UpdateEnvironment(float deltaPollution = 0f, float deltaNaturalResources = 0f)
    {
        EnvironmentData.ChangePollution(deltaPollution);
        EnvironmentData.ChangeNaturalResources(deltaNaturalResources);
    }
    #endregion
}
