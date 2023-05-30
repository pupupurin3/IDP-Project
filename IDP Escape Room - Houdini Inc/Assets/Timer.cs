using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Networking;

public class Timer : MonoBehaviour
{
    /// Maximum time limit in seconds.
    public const float MAX_TIME_LIMIT = 1800;
    /// Penalty time in seconds.
    public const float PENALTY_TIME = 20;

    /// Remaining time for the user.
    public static float TimeValue = MAX_TIME_LIMIT;
    /// Remaining time value for the last puzzle solved.
    public static float LastPuzzleTimeValue = MAX_TIME_LIMIT;

    /// Current puzzle number.
    public static float PuzzleCounter = 1;

    /// UI to display time.
    public TextMeshProUGUI timeText;

    /// Google form url to save data.
    [SerializeField]
    private string GOOGLE_FORM_URL = "https://docs.google.com/forms/u/1/d/e/1FAIpQLScmoPQQonKGFYNqzQoNB5MAapfHPOrRqwD9xpaF86czpltS7Q/formResponse";

    /// Post form data to google form (Player's name, Puzzle number, and Elapsed time).
    IEnumerator PostFormDataToGoogle(string player, string puzzleNum, string elapsedTime) 
    {   
        Debug.LogWarning("Inside PostFormData: " + GOOGLE_FORM_URL); 
        WWWForm form = new WWWForm();
        form.AddField("entry.182013201", player);
        form.AddField("entry.316933456", puzzleNum);
        form.AddField("entry.1377343469", elapsedTime);
        Debug.LogWarning($"--- {player}, {puzzleNum}, {elapsedTime}");

        float t1 = float.Parse(PlayerPrefs.GetString("Time" + puzzleNum, "1800"));
        float t2 = float.Parse(elapsedTime);
        if (t2 < t1)
        {
            PlayerPrefs.SetString("Player" + puzzleNum, player);
            PlayerPrefs.SetString("Time" + puzzleNum, t2.ToString("0.00"));
        }
        PlayerPrefs.Save();

        UnityWebRequest webRequest = UnityWebRequest.Post(GOOGLE_FORM_URL, form);
        yield return webRequest.SendWebRequest();
        
        if (webRequest.result != UnityWebRequest.Result.Success)
        {
            Debug.LogWarning("Form failed. Error: " + webRequest.error);
        }
    }

    /// Send form data to google based on current user data. 
    public void SendFormDataToGoogle() 
    {
        string player = PlayerPrefs.GetString("CurrentPlayer", "--");
        string puzzleNum = PuzzleCounter.ToString();
        PuzzleCounter++;
        string elapsedTime = (LastPuzzleTimeValue - TimeValue).ToString();
        LastPuzzleTimeValue = TimeValue;
        StartCoroutine(PostFormDataToGoogle(player, puzzleNum, elapsedTime));
    }

    /// Logs the current time.
    public void LogTimer()
    {
        Debug.LogWarning("Time Value:" + timeText.text);
    }

    /// Update is called once per frame. Update the current time.
    void Update()
    {
        if(TimeValue > 0)
        {
            TimeValue -= Time.deltaTime;
        }
        else
        {
            TimeValue = 0;
        }

        DisplayTime(TimeValue);
    }

    /// Displays current time.
    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    /// Deducts time when user clicks hint button.
    public void DeductTime()
    {
        TimeValue = TimeValue - PENALTY_TIME;
        Debug.LogWarning(TimeValue);
    }
}