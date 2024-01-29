using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseData : MonoBehaviour
{
    public float Military { get; private set; }
    public float Security { get; private set; } 
    public float Intelligence { get; private set; }

    public DefenseData()
    {
        this.Military = 0;
        this.Security = 0;
        this.Intelligence = 0;
    }

    public DefenseData(float military, float security, float intelligence)
    {
        this.Military = military;
        this.Security = security;
        this.Intelligence = intelligence;
    }
    
    /// <summary>
    /// Military Represents national defense capabilities and global military influence. 
    /// It involves factors such as the strength and size of a nation's armed forces,
    /// military technology, defense infrastructure, and strategic geopolitical influence.
    /// </summary>
    public void ChangeMilitary(float deltaMilitary)
    {
        this.Military += deltaMilitary;
    }
    /// <summary>
    /// Security Represents a nation's internal security measures. 
    /// These could include law enforcement capabilities, secure borders,
    /// counter-terrorism operations, and overall public safety measures.
    /// </summary>
    public void ChangeSecurity(float deltaSecurity)
    {
        this.Security += deltaSecurity;
    }
    /// <summary>
    /// Intelligence Represents the structure and efficiency of a nation's intelligence agencies.
    /// It encompasses elements like international espionage capabilities, intelligence analysis,
    /// counterintelligence operations, and information collection and dissemination.
    /// </summary>
    public void ChangeIntelligence(float deltaIntelligence)
    {
        this.Intelligence += deltaIntelligence;
    }
}
