using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseManager : MonoBehaviour
{
    public static DefenseManager Instance { get; private set; }
    public DefenseData DefenseData { get; private set; }
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DefenseData = new DefenseData();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    #region methods

    public void ChangeMilitary(float deltaMilitary)
    {
        DefenseData.ChangeMilitary(deltaMilitary);
    }
    
    public void ChangeSecurity(float deltaSecurity)
    {
        DefenseData.ChangeSecurity(deltaSecurity);
    }
    
    public void ChangeIntelligence(float deltaIntelligence)
    {
        DefenseData.ChangeIntelligence(deltaIntelligence);
    }

    #endregion
}
