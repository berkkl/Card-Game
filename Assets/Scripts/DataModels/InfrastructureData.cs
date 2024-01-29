using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfrastructureData : MonoBehaviour
{
    public float Infrastructure { get; private set; }
    public float Research { get; private set; }

    public InfrastructureData()
    {
        this.Infrastructure = 0;
        this.Research = 0;
    }

    public InfrastructureData(float infrastructure, float research)
    {
        this.Infrastructure = infrastructure;
        this.Research = research;
    }
    /// <summary>
    /// Represents the quality and extent of the physical structures serving a country.
    /// This can include transportation systems, telecommunications, power plants,
    /// and public utilities.
    /// </summary>
    public void ChangeInfrastructure(float deltaInfrastructure)
    {
        this.Infrastructure += deltaInfrastructure;
    }
    /// <summary>
    /// Represents the capacity and productivity of a country's scientific and technological
    /// research entities. This can take into account the amount of published research,
    /// the reputation of research institutions, and investment in R&D.
    /// </summary>
    public void ChangeResearch(float deltaResearch)
    {
        this.Research += deltaResearch;
    }
}
