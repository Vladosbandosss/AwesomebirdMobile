using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    public static GameManger instance;
    [SerializeField] Text diamontScore;

    [SerializeField] GameObject startPanel;

    int score = 0;
   public bool  isGameStafrted;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void IncreaseScore()
    {
        score++;
        diamontScore.text = score.ToString();
    }

    private void Update()
    {
        if (Input.anyKey)
        {
            startPanel.SetActive(false);
            isGameStafrted = true;
        }
    }
}
