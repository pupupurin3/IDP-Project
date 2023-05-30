using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class NameInput : MonoBehaviour
{
    public Flowchart flowchart; // Reference to your Fungus Flowchart
    public StringData playerNameVariable; // Reference to your Fungus String variable

    private InputField inputField;

    private void Awake()
    {
        inputField = GetComponent<InputField>();
        inputField.onEndEdit.AddListener(OnEndEdit);
    }

    private void OnEndEdit(string text)
    {
        playerNameVariable.Value = text;
        flowchart.ExecuteBlock("GetName"); // Replace "YourBlockName" with the actual block name in your Fungus Flowchart
    }
}