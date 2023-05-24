using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Piano : MonoBehaviour
{
    public int Ccount;
    public int Acount;
    public int Gcount;
    public int Ecount;
    public bool solved;

    

    public void OtherNote()
    {
        Ccount = 0;
        Acount = 0;
        Gcount = 0;
        Ecount = 0;
    }

    public void CClick()

    {
        if(Ccount == 0 && Acount == 0 && Gcount == 0 && Ecount == 0)
        {
            Ccount++;
        }
        else
        {
            Ccount = 0;
            Acount = 0;
            Gcount = 0;
            Ecount = 0;
        }
    }

    
    public void AClick()
    {
        if(Ccount == 1 && Acount == 0 && Gcount == 0 && Ecount == 0)
        {
            Acount++;
        }
        else
        {
            Ccount = 0;
            Acount = 0;
            Gcount = 0;
            Ecount = 0;
        }
    }

    public void GClick()
    {
        if(Ccount == 1 && Acount == 1 && Gcount == 0 && Ecount == 0)
        {
            Gcount++;
        }
        else
        {
            Ccount = 0;
            Acount = 0;
            Gcount = 0;
            Ecount = 0;
        }
    }
    
    public void EClick()
    {
        if(Ccount == 1 && Acount == 1 && Gcount == 1 && Ecount == 0)
        {
            Ecount++;
        }
        else
        {
            Ccount = 0;
            Acount = 0;
            Gcount = 0;
            Ecount = 0;
        }

        solved = false;

        if(Ccount == 1 && Acount == 1 && Gcount == 1 && Ecount == 1)
        {
            solved = true;
        }

        void solvedpuzzle()
        {
            SceneManager.LoadScene(4);

        }

        if(solved)
        {
            solvedpuzzle();
        }
    }
}
