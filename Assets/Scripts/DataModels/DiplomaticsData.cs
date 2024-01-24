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
    
    public void ChangeInternationalRelations(float deltaInternationalRelations)
    {
        this.internationalRelations += deltaInternationalRelations;
    }
}
