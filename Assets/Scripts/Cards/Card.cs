using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public string cardName;
    public string description;
    //public Sprite artwork;
    /// <summary>
    /// Represents the type of a card.
    /// We can use it for filtering cards in the UI.
    /// And we may use different color of sprites to represent the card type.
    /// </summary>
    public enum CardType
    {
        Economic, Diplomatic, Population, Environmental, Infrastructure, Defense, Governance, Complex, Spell 
    }
    public CardType cardType;
    
    public float deltaMilitary;
    public float deltaSecurity;
    public float deltaIntelligence;
    public float deltaInternationalRelations;
    public float deltaMoney;
    public float deltaInflation;
    public float deltaProduction;
    public float deltaPollution;
    public float deltaNaturalResources;
    public float deltaPoliticalPower;
    public float deltaEducationLevel;
    public float deltaInfrastructure;
    public float deltaResearch;
    public float deltaPopulation;
    public float deltaHappiness;
    public float deltaHealthcare;
    
    public void ExecuteCardEffect()
    {
        EconomyManager.Instance.UpdateEconomy(deltaMoney, deltaInflation, deltaProduction);
        DefenseManager.Instance.UpdateDefense(deltaMilitary, deltaSecurity, deltaIntelligence);
        DiplomaticsManager.Instance.UpdateDiplomacy(deltaInternationalRelations);
        EnvironmentManager.Instance.UpdateEnvironment(deltaPollution, deltaNaturalResources);
        GovernanceManager.Instance.UpdateGovernance(deltaPoliticalPower, deltaEducationLevel);
        InfrastructureManager.Instance.UpdateInfrastructure(deltaInfrastructure, deltaResearch);
        PopulationManager.Instance.UpdatePopulation(deltaPopulation, deltaHappiness, deltaHealthcare);
    }
}