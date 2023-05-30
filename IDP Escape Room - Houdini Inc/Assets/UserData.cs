using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserData : MonoBehaviour
{
    public Text PlayerNameText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    /// Save current player's name.
    public void SavePlayerName()
    {
        PlayerPrefs.SetString("CurrentPlayer", PlayerNameText.text);
    }
}
