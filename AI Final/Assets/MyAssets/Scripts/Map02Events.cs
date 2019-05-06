using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Map02Events : MonoBehaviour
{
    public GameObject TheDestination;
    public GameObject TheDestination2;
    public GameObject TheDestination3;
    public static bool TriggerNoice = false;
    public static bool TriggerNoice2 = false;
    public static bool TriggerNoice3 = false;
    //NavMeshAgent TheAgent;
    // Start is called before the first frame update
    void Start()
    {
        //TheAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        if (gameObject == TheDestination)
        {
            TriggerNoice2 = false;
            TriggerNoice3 = false;
            TriggerNoice = true;
            //Debug.Log("WORKING");
        }
        else if (gameObject == TheDestination2)
        {
            TriggerNoice = false;
            TriggerNoice3 = false;
            TriggerNoice2 = true;
        }
        else if (gameObject == TheDestination3)
        {
            Debug.Log("WORKING");
            TriggerNoice = false;
            TriggerNoice2 = false;
            TriggerNoice3 = true;
        }
    }

    void OnTriggerExit()
    {
        TriggerNoice3 = false;
    }
}
