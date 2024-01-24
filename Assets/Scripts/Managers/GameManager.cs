using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{    
    public static GameManager instance;

    //public PlayerController playerController; // Reference to player controller
    //public AIController aiController; // Reference to AI controller

    public enum GameState { Preparation, Player_Turn, AI_Turn, End_Game }
    public GameState gameState;

    void Awake() {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    void Start() {
        // Initialize game, setup board, shuffle cards, etc.
        // Set the initial game state
        gameState = GameState.Preparation;
    }

    void Update() {
        switch(gameState) {
            case GameState.Preparation:
                // Initialize the round
                break;
            case GameState.Player_Turn:
                // Handle player's turn
                break;
            case GameState.AI_Turn:
                // Handle AI's turn
                break;
            case GameState.End_Game:
                // Handle end game
                break;
        }
    }

    public void EndTurn() {
        // Contains logic for when to end a player's turn and pass it to the AI
    }
}
