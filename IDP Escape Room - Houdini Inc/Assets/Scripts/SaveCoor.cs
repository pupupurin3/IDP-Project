using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveCoor : MonoBehaviour
{
    public float x,y,z;


    public void SaveCoordinate()
    {
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;

        PlayerPrefs.SetFloat("x",x);
        PlayerPrefs.SetFloat("y",y);
        PlayerPrefs.SetFloat("z",z);
    }

    public void loadCoordinate()
    {
        x = PlayerPrefs.GetFloat("x");
        y = PlayerPrefs.GetFloat("y");
        z = PlayerPrefs.GetFloat("z");

        Vector3 LoadPosition = new Vector3(x,y,z);
        transform.position = LoadPosition;
    }
}