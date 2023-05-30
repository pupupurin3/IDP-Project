using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class SurveyData : MonoBehaviour
{
    /// Google form url to save data.
    [SerializeField]
    private string GOOGLE_FORM_URL = "https://docs.google.com/forms/u/1/d/e/1FAIpQLSfadbUpiCkv7TwVNNNYMPFlw5OKtDRlVMBKWiwuNa9X0URMZA/formResponse";

    public Text PlayerSurveyText;

    /// Save player's feedback.
    IEnumerator PostPlayerFeedbackToGoogle()
    {
        PlayerPrefs.SetString("PlayerFeedback", PlayerSurveyText.text);
        Debug.LogWarning("Player Feedback: " + PlayerSurveyText.text);

        WWWForm form = new WWWForm();
        form.AddField("entry.140125965", PlayerPrefs.GetString("CurrentPlayer", "Anonymous"));
        form.AddField("entry.1593276428", PlayerSurveyText.text);
        Debug.LogWarning($"--- Player Feedback: {PlayerSurveyText.text}");
        UnityWebRequest webRequest = UnityWebRequest.Post(GOOGLE_FORM_URL, form);
        yield return webRequest.SendWebRequest();
        
        if (webRequest.result != UnityWebRequest.Result.Success)
        {
            Debug.LogWarning("Form failed. Error: " + webRequest.error);
        }
    }

    /// Send the player's feedback to google. 
    public void SendPlayerFeedbackToGoogle() 
    {
        StartCoroutine(PostPlayerFeedbackToGoogle());
    }
}
