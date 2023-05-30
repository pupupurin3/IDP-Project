using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Leaderboard : MonoBehaviour
{
    private string playerName = "Bianca";
    private int puzzleNum = 1;
    private int elapsedTime = 10;
    public TMP_Text PlayerText;
    public TMP_Text PuzzleText;
    public TMP_Text TimeText;
    
    void Start()
    {

    }

    /// Update is called once per frame.
    void Update()
    {
        PlayerText.text = playerName;
        PuzzleText.text = puzzleNum.ToString();
        TimeText.text = elapsedTime.ToString();       
    }
    
    /// Save player name.
    public void SavePlayerName()
    {
        Debug.LogWarning("Saving player name");
    }
}