using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiplomaticsManager : MonoBehaviour
{
    public static DiplomaticsManager Instance { get; private set; }
    public DiplomaticsData DiplomaticsData { get; private set; }
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DiplomaticsData = new DiplomaticsData();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #region methods

    /// <summary>
    /// Updates the international relations by a given delta.
    /// </summary>
    /// <param name="deltaIR">The change in international relations. Default value is 0.</param>
    public void UpdateDiplomacy(float deltaIR = 0f)
    {
        DiplomaticsData.ChangeInternationalRelations(deltaIR);
    }
    #endregion
}
