using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiplomaticsData : MonoBehaviour
{
    public float internationalRelations { get; private set; }

    public DiplomaticsData()
    {
        this.internationalRelations = 0;
    }
    
    public DiplomaticsData(float internationalRelations)
    {
        this.internationalRelations = internationalRelations;
    }
    
    /// <summary>
    /// Represents a country's global standing in terms of its diplomatic relations with other nations. 
    /// It might encompass elements like the nation's reputation, its alliances, treaties, international conflicts, 
    /// and its general standing in the global community.
    /// </summary>
    public void ChangeInternationalRelations(float deltaInternationalRelations)
    {
        this.internationalRelations += deltaInternationalRelations;
    }
}
