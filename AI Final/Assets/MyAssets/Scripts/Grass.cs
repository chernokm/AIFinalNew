using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grass : MonoBehaviour
{
    //public GameObject grass;
    public int ClosedObjective;

    public bool insideGrass = true;
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        insideGrass = true;
        //StartCoroutine(InsideGrass());
    }

    private void OnTriggerExit()
    {
        insideGrass = false;
    }

    /*
    IEnumerator InsideGrass()
    {
        grass.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        ClosedObjective = 1;
    }
    */
}
