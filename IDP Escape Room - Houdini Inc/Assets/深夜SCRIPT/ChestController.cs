using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChestController : MonoBehaviour 
{
    public bool isOpen;

    public void OpenChest()
    {
        isOpen = true;
        Debug.Log("Chest is now open...");
    }
}