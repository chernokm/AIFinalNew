using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public GameObject TheDestination;
    public GameObject TheDestination2;
    NavMeshAgent TheAgent;
    public GameObject HidingPlace;
    //public GameObject ThePlayer;
    //Grass gras = new Grass();

    //Grass grass;
    //public bool insideGrass = false;

    void Start()
    {
        TheAgent = GetComponent<NavMeshAgent>();
        //bool grass = GetComponent<Grass>();
    }

    void OnTriggerEnter()
    {
        if (gameObject == HidingPlace)
        {
            Debug.Log("ONTRIGGERWORKS");
        }
    }
    void Update()
    {

        StartCoroutine("Loop");
        TheAgent.SetDestination(TheDestination.transform.position);

    }

    IEnumerator Loop()
    {
        if (gameObject == HidingPlace)
        {
            TheAgent.SetDestination(TheDestination.transform.position);
        }
        //if(grass == false)
        //{
        //    TheAgent.SetDestination(TheDestination2.transform.position);
        //}
        //else if (grass == true)
        //{
        //    TheAgent.SetDestination(TheDestination.transform.position);
        //}
        //TheAgent.SetDestination(TheDestination.transform.position);
        yield return new WaitForSeconds(0.5f);
    }
   
}
