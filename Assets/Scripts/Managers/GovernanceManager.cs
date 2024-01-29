using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GovernanceManager : MonoBehaviour
{
    public static GovernanceManager Instance { get; private set; }
    public GovernanceData GovernanceData { get; private set; }
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            GovernanceData = new GovernanceData();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    #region methods

    /// <summary>
    /// Updates the governance data with the given changes in political power and education level.
    /// </summary>
    /// <param name="deltaPoliticalPower">The change in political power.</param>
    /// <param name="deltaEducationLevel">The change in education level.</param>
    public void UpdateGovernance(float deltaPoliticalPower = 0f, float deltaEducationLevel = 0f)
    {
        GovernanceData.ChangePoliticalPower(deltaPoliticalPower);
        GovernanceData.ChangeEducationLevel(deltaEducationLevel);
    }
    #endregion
}
