using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GovernanceData : MonoBehaviour
{
    public float PoliticalPower { get; private set; }
    public float EducationLevel { get; private set; }
    
    public GovernanceData()
    {
        this.PoliticalPower = 0;
        this.EducationLevel = 0;
        //this.ResearchLevel = 0;
    }
    
    public GovernanceData(float politicalPower, float educationLevel)
    {
        this.PoliticalPower = politicalPower;
        this.EducationLevel = educationLevel;
    }
    
    public void ChangePoliticalPower(float deltaPoliticalPower)
    {
        this.PoliticalPower += deltaPoliticalPower;
    }
    
    public void ChangeEducationLevel(float deltaEducationLevel)
    {
        this.EducationLevel += deltaEducationLevel;
    }
}
