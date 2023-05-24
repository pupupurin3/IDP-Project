using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LockPick : MonoBehaviour
{
    public int onecount;
    public int twocount;
    public int threecount;
    public int fourcount;
    public int fivecount;
    public int sixcount;

    public bool solvedpic;


    // The order of the picking pins are num.
    //4
    //2
    //5
    //1
    //3
    //6

    public void fourinc()

    {
        if(onecount == 0 && twocount == 0 && threecount == 0 && fourcount == 0 && fivecount == 0 && sixcount == 0) 
        {
            fourcount++;
        }
        else
        {
            onecount = 0;
            twocount = 0;
            threecount = 0;
            fourcount = 0;
            fivecount = 0;
            sixcount = 0;
        }
    }

    
    public void twoinc()

    {
        if(onecount == 0 && twocount == 0 && threecount == 0 && fourcount == 1 && fivecount == 0 && sixcount == 0) 
        {
            twocount++;
        }
        else
        {
            onecount = 0;
            twocount = 0;
            threecount = 0;
            fourcount = 0;
            fivecount = 0;
            sixcount = 0;
        }
    }

    public void fiveinc()

    {
        if(onecount == 0 && twocount == 1 && threecount == 0 && fourcount == 1 && fivecount == 0 && sixcount == 0) 
        {
            fivecount++;
        }
        else
        {
            onecount = 0;
            twocount = 0;
            threecount = 0;
            fourcount = 0;
            fivecount = 0;
            sixcount = 0;
        }
    }

    public void oneinc()

    {
        if(onecount == 0 && twocount == 1 && threecount == 0 && fourcount == 1 && fivecount == 1 && sixcount == 0) 
        {
            onecount++;
        }
        else
        {
            onecount = 0;
            twocount = 0;
            threecount = 0;
            fourcount = 0;
            fivecount = 0;
            sixcount = 0;
        }
    }

    public void threeinc()

    {
        if(onecount == 1 && twocount == 1 && threecount == 0 && fourcount == 1 && fivecount == 1 && sixcount == 0) 
        {
            threecount++;
        }
        else
        {
            onecount = 0;
            twocount = 0;
            threecount = 0;
            fourcount = 0;
            fivecount = 0;
            sixcount = 0;
        }
    }

    public void sixinc()

    {
        if(onecount == 1 && twocount == 1 && threecount == 1 && fourcount == 1 && fivecount == 1 && sixcount == 0) 
        {
            sixcount++;
        }
        else
        {
            onecount = 0;
            twocount = 0;
            threecount = 0;
            fourcount = 0;
            fivecount = 0;
            sixcount = 0;
        }
        
        solvedpic = false;

        if(onecount == 1 && twocount == 1 && threecount == 1 && fourcount == 1 && fivecount == 1 && sixcount == 1)
        {
            solvedpic = true;
        }

        void solvedpuzzlepic()
        {
            SceneManager.LoadScene(4);

        }

        if(solvedpic)
        {
            solvedpuzzlepic();
        }
        
}
}
