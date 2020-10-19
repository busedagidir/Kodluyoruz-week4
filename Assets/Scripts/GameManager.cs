using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq; //find & search


public class GameManager : MonoBehaviour
{

    //progress bar için
    private static GameManager _instance;
    private GameState _gameState;
    private Slider _progressBar;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        DontDestroyOnLoad(this);
    }

    public static GameManager Instance()
    {
        return _instance;
    }

    private void Start()
    {
        PrepareGame();
    }

    private void PrepareGame()
    {
        _gameState = new GameState();
        _gameState.totalCheckPoint = 5;
    }

    //oyun sonu 
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    //baslangıc ekranı icin
    
}

