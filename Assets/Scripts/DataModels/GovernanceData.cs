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
    }
    
    public GovernanceData(float politicalPower, float educationLevel)
    {
        this.PoliticalPower = politicalPower;
        this.EducationLevel = educationLevel;
    }
    
    /// <summary>
    /// Represents the amount of political power held by the governing body. This could be
    /// related to the strength and influence of political leadership, degree of centralization,
    /// and the overall ability to enforce policies and decisions.
    /// </summary>
    public void ChangePoliticalPower(float deltaPoliticalPower)
    {
        this.PoliticalPower += deltaPoliticalPower;
    }
    /// <summary>
    /// Represents the average education level of individuals within the governance.
    /// It could account for various factors such as literacy rate, rate of graduation, expertise
    /// in specialized areas, and the overall intellectual capital available to the governance.
    /// </summary>
    public void ChangeEducationLevel(float deltaEducationLevel)
    {
        this.EducationLevel += deltaEducationLevel;
    }
}
