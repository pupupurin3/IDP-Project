using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Leaderboard : MonoBehaviour
{
    public TMP_Text PlayerText;
    public TMP_Text PuzzleText;
    public TMP_Text TimeText;
    
    void Start()
    {
        // This resets the values in the leaderboard.
        //  PlayerPrefs.DeleteAll();
    }

    /// Update is called once per frame.
    void Update()
    {
        string p1 = PlayerPrefs.GetString("Player1", "--");
        string p2 = PlayerPrefs.GetString("Player2", "--");
        string p3 = PlayerPrefs.GetString("Player3", "--");
        string p4 = PlayerPrefs.GetString("Player4", "--");
        string p5 = PlayerPrefs.GetString("Player5", "--");
        string p6 = PlayerPrefs.GetString("Player6", "--");
        string p7 = PlayerPrefs.GetString("Player7", "--");
        string p8 = PlayerPrefs.GetString("Player8", "--");
        string p9 = PlayerPrefs.GetString("Player9", "--");
        string t1 = PlayerPrefs.GetString("Time1", "--");
        string t2 = PlayerPrefs.GetString("Time2", "--");
        string t3 = PlayerPrefs.GetString("Time3", "--");
        string t4 = PlayerPrefs.GetString("Time4", "--");
        string t5 = PlayerPrefs.GetString("Time5", "--");
        string t6 = PlayerPrefs.GetString("Time6", "--");
        string t7 = PlayerPrefs.GetString("Time7", "--");
        string t8 = PlayerPrefs.GetString("Time8", "--");
        string t9 = PlayerPrefs.GetString("Time9", "--");
        PlayerText.text = $"{p1}\n{p2}\n{p3}\n{p4}\n{p5}\n{p6}\n{p7}\n{p8}\n{p9}";
        PuzzleText.text = "1\n2\n3\n4\n5\n6\n7\n8\n9";
        TimeText.text = $"{t1}\n{t2}\n{t3}\n{t4}\n{t5}\n{t6}\n{t7}\n{t8}\n{t9}";       
    }
    
    /// Save player name.
    public void SavePlayerName()
    {
        Debug.LogWarning("Saving player name");
    }
}