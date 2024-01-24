using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfrastructureData : MonoBehaviour
{
    public float Infrastructure { get; private set; }
    public float Education { get; private set; }
    public float Research { get; private set; }

    public InfrastructureData()
    {
        this.Infrastructure = 0;
        this.Education = 0;
        this.Research = 0;
    }

    public InfrastructureData(float infrastructure, float education, float research)
    {
        this.Infrastructure = infrastructure;
        this.Education = education;
        this.Research = research;
    }
    
    public void ChangeInfrastructure(float deltaInfrastructure)
    {
        this.Infrastructure += deltaInfrastructure;
    }

    public void ChangeEducation(float deltaEducation)
    {
        this.Education += deltaEducation;
    }

    public void ChangeResearch(float deltaResearch)
    {
        this.Research += deltaResearch;
    }
}
