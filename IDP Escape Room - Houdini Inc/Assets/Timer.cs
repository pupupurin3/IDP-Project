using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Networking;
// using Fungus;

public class Timer : MonoBehaviour
{
    public const float MAX_TIME_LIMIT = 1800;
    public static float TimeValue = MAX_TIME_LIMIT;
    public static float LastPuzzleTimeValue = MAX_TIME_LIMIT;

    public static float PuzzleCounter = 1;

    public TextMeshProUGUI timeText;
    // public Flowchart fungusFlowchart;

    [SerializeField]
    private string GOOGLE_FORM_URL = "https://docs.google.com/forms/u/1/d/e/1FAIpQLScmoPQQonKGFYNqzQoNB5MAapfHPOrRqwD9xpaF86czpltS7Q/formResponse";

    IEnumerator PostFormDataToGoogle(string player, string puzzleNum, string elapsedTime) 
    {   
        Debug.LogWarning("Inside PostFormData: " + GOOGLE_FORM_URL); 
        WWWForm form = new WWWForm();
        form.AddField("entry.182013201", player);
        form.AddField("entry.316933456", puzzleNum);
        form.AddField("entry.1377343469", elapsedTime);       

        UnityWebRequest webRequest = UnityWebRequest.Post(GOOGLE_FORM_URL, form);
        yield return webRequest.SendWebRequest();
        

        if (webRequest.result == UnityWebRequest.Result.Success)
        {
            Debug.LogWarning("Form submitted successfully.");
        }
        else
        {
            Debug.LogWarning("Form failed. Error: " + webRequest.error); 
        }
    }
   
    public void SendFormDataToGoogle() 
    {
        string player = "chrizZ"; // TODO: need to add player name
        string puzzleNum = PuzzleCounter.ToString();
        PuzzleCounter++;
        string elapsedTime = (LastPuzzleTimeValue - TimeValue).ToString();
        LastPuzzleTimeValue = TimeValue;
        StartCoroutine(PostFormDataToGoogle(player, puzzleNum, elapsedTime));
    }

    // int GetPuzzleNum()
    // {
    //     int puzzleNum = fungusFlowchart.GetIntegerVariable("PuzzleNum");
    //     Debug.Log("Puzzle Num: " + puzzleNum);
    //     return puzzleNum;
    // }

    public void LogTimer()
    {
        Debug.LogWarning("Time Value:" + timeText.text);
    }

    // Update is called once per frame
    void Update()
    {
        if(TimeValue >0)
        {
            TimeValue -= Time.deltaTime;
        }
        else
        {
            TimeValue = 0;
        }

        DisplayTime(TimeValue);
    }

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
}