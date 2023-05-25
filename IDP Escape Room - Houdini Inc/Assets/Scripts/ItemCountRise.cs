using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCountRise : MonoBehaviour
{
    public int keyACount;
    public int keyBCount;
    public int GlueCount;
    GameObject interactNotification;


    public void Start()
    {
        interactNotification = GameObject.Find ("interactNotification");
        interactNotification.SetActive(false);
    }

    public void PickupKeyPartA()
    {
        if(keyACount == 0)
        {
            keyACount++;   
        }

        else if(keyACount > 1)
        {
            Debug.Log("No more keys");
        }
       
    }

    public void UseKeyPartA()
    {
        keyACount--;
    }

    public void PickupKeyPartB()
    {
        if(keyBCount == 0)
        {
            keyBCount++;   
        }

        else if(keyBCount > 0)
        {
            Debug.Log("No more keys");
        }
       
    }

    public void UseKeyPartB()
    {
        keyBCount--;
    }

    public void PickupGlue()
    {
        GlueCount ++;
    }

    public void UseGlue()
    {
        GlueCount --;
    }
    
    public void MakeKey()
    {
        if(keyBCount == 1 && keyACount == 1 && GlueCount == 1)
        {

        }
    }

    public void NotifyPlayer()
    {
        interactNotification.SetActive(true);
    }

    public void DeNotifyPlayer()
    {
        interactNotification.SetActive(false);
    }

}
