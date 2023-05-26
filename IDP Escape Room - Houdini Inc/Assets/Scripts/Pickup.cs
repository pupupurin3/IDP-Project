using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
    private Inventory inventory;

    private void Start()
    {
        inventory = GameObject.findGameObjectWithTag("Player").GetComponent<Inventory>();                                                                    
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
