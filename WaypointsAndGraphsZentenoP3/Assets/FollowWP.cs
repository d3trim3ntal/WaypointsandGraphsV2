using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowWP : MonoBehaviour
{

    public GameObject wpManager;
    GameObject[] wps;
    GameObject currentNode;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        wps = wpManager.GetComponent<WPManager>().waypoints;
        currentNode = wps[0];
        Time.timeScale = 3;

        agent = this.GetComponent<NavMeshAgent>();

        //Invoke("GoToRuin", 2);
    }

    public void GoToHeli()
    {
        //g.AStar(currentNode, wps[0]);
        agent.SetDestination(wps[0].transform.position);
    }

    public void GoToRuin()
    {
        //g.AStar(currentNode, wps[1]);
        agent.SetDestination(wps[1].transform.position);
    }

    public void GoToFactory()
    {
        //g.AStar(currentNode, wps[4]);
        agent.SetDestination(wps[4].transform.position);

    }

    // Update is called once per frame
    void LateUpdate()
    {
       
    }
}
