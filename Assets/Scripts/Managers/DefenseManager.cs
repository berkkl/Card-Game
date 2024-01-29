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

    /// <summary>
    /// Updates the defense values for the current entity.
    /// </summary>
    /// <param name="deltaMilitary">The change in military defense value.</param>
    /// <param name="deltaSecurity">The change in security defense value.</param>
    /// <param name="deltaIntelligence">The change in intelligence defense value.</param>
    public void UpdateDefense(float deltaMilitary = 0f, float deltaSecurity = 0f, float deltaIntelligence = 0f)
    {
        DefenseData.ChangeMilitary(deltaMilitary);
        DefenseData.ChangeSecurity(deltaSecurity);
        DefenseData.ChangeIntelligence(deltaIntelligence);
    }
    #endregion
}
