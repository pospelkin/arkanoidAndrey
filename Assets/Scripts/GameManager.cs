using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    menu,
    inGame,
    gameOver
}

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameState currentGameState = GameState.menu; 
    //
    private void Start() {
        currentGameState = GameState.menu;
    }

    private void Awake() {
        instance = this;
    }

    public void StartGame ()
    {
      //  PlayerController.instance.StartGame();
      //  SetGameState(GameState.inGame);
    }

    public void InGame()
    {
        SetGameState(GameState.inGame);
    }

    public void GameOver()
    {
        SetGameState(GameState.gameOver);
    }

    public void SetGameState(GameState newGameState)
    {
        if(newGameState == GameState.menu) {
            //Говорит Юнити, что мы в меню
        }
        if(newGameState == GameState.inGame){
            //Говорит Юнити, что мы в игре
        }
        if(newGameState == GameState.gameOver){
            //Готоврит Юнити, что игра законцена
        }
        currentGameState = newGameState; 
    }
}

