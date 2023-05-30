using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class UserData : MonoBehaviour
{
    public Flowchart InputFlowchart;
    private string PlayerName;

    // Start is called before the first frame update
    void Start()
    {
        InputFlowchart = FindObjectOfType<Flowchart>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// Save current player's name.
    public void SavePlayerName()
    {
        PlayerName = InputFlowchart.GetStringVariable("PlayerName");
        Debug.LogWarning("Player Name: " + PlayerName);
    }
}
