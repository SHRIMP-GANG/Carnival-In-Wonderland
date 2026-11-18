using UnityEditor.Purchasing;
using UnityEngine;
using UnityEngine.AI;

public class CarnivalAI : MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject player;
    public GameObject target;

    private enum State {CHASING, SEARCHING};
    private State state;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.transform.position);
    }
}
