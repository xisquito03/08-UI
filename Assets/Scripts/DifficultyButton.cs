using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
public int difficulty;
private Button _button;
private GameManager gameManager;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(setDifficulty);
    }

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void setDifficulty()
    {
        gameManager.StartGame(difficulty);
    }
}
