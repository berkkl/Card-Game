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
    
    public void ChangePoliticalPower(float deltaPoliticalPower)
    {
        GovernanceData.ChangePoliticalPower(deltaPoliticalPower);
    }
    
    public void ChangeEducationLevel(float deltaEducationLevel)
    {
        GovernanceData.ChangeEducationLevel(deltaEducationLevel);
    }

    #endregion
}
