using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    NavMeshAgent TheAgent;
    private static bool noice;
    private static bool noice2;
    private static bool noice3;
    public GameObject GOTO;
    public GameObject GOTO2;
    public GameObject GOTO3;
    //public GameObject TheDestination;

    //public GameObject ThePlayer;
    //public float TargetDistance;
    //public float AllowedRange;
    //public GameObject TheEnemy;
    //public float EnemySpeed;
    //public int AttackTrigger;
    //public RaycastHit Shot;
    // Start is called before the first frame update
    void Start()
    {
        TheAgent = GetComponent<NavMeshAgent>();
        //noice = Map02Events.TriggerNoice;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
        //{
        //    TargetDistance = Shot.distance;
        //    if (TargetDistance <= AllowedRange)
        //    {
        //        noice = false;
        //        noice2 = false;
        //        EnemySpeed = 0.02f;
        //        if (AttackTrigger == 0)
        //        {
        //            transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, EnemySpeed);
        //        }
        //    }
        //    else
        //    {
        //        EnemySpeed = 0;
        //    }
        //}

        noice = Map02Events.TriggerNoice;
        noice2 = Map02Events.TriggerNoice2;
        noice3 = Map02Events.TriggerNoice3;
        if (noice == true)
        {
            //Debug.Log("EnemyMovement works");
            TheAgent.SetDestination(GOTO.transform.position);
        }
        else if (noice2 == true)
        {
            TheAgent.SetDestination(GOTO2.transform.position);
        }
        else if (noice3 == true)
        {
            TheAgent.SetDestination(GOTO3.transform.position);
        }

        
        
    }
}
