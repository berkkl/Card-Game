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
    
    public void ChangeMilitary(float deltaMilitary)
    {
        this.Military += deltaMilitary;
    }

    public void ChangeSecurity(float deltaSecurity)
    {
        this.Security += deltaSecurity;
    }

    public void ChangeIntelligence(float deltaIntelligence)
    {
        this.Intelligence += deltaIntelligence;
    }
}
