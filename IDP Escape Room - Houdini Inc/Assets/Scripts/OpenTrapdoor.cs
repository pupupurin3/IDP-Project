using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenTrapdoor : MonoBehaviour
{
   public bool isOpen;

   public void OpenTrap(ItemCountRise obj)
   {
        if(!isOpen)
            {
            ItemCountRise manager = obj.GetComponent<ItemCountRise>();
            if (manager)
            {
                if(manager.keyBCount > 0)
                {
                    isOpen = true;
                    manager.UseKeyPartB();
                }
            }  
        }
        
        

   }
}