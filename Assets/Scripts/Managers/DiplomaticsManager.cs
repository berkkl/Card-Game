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
    
    public void ChangeInternationalRelations(float deltaMilitary)
    {
        DiplomaticsData.ChangeInternationalRelations(deltaMilitary);
    }
    #endregion
}
