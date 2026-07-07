using UnityEngine;

public enum GameState {orders, move, combat, extraction, construction}
public class GameManagerScript : MonoBehaviour
{
    [Header("Interactions")]
    // This is for stuff like uimanager, soundmanager, and other things that need to interact with a unit

    [Header("Stats")]
    // This is for unit stats, including hp, soft damage, hard damage, air damage, speed, range, target, classification, cost

    [Tooltip("Current state of the game (aka phase)")]
    public GameState gameState;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToNextPhase()
    {
        gameState = (GameState)(((int)gameState + 1) % System.Enum.GetValues(typeof(GameState)).Length);
    }
}
