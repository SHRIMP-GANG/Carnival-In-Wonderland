using UnityEditor.Purchasing;
using UnityEngine;
using UnityEngine.AI;

public class CarnivalAI : MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject player;
    public GameObject target;

    private enum State
    {
        CHASING,
        SEARCHING
    };

    private State state;

    public GameObject randomTargetParent;
    private GameObject[] randomTargets;

    public float searchSpeed=2.5f;
    public float chaseSpeed=5f;

    public bool debugRay = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
        int childCount = randomTargetParent.transform.childCount;
        randomTargets = new GameObject[childCount];
        for (int i = 0; i < childCount; i++)
        {
            randomTargets[i] = randomTargetParent.transform.GetChild(i).gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerVisible())
        {
            target.transform.position = player.transform.position;
            if (state != State.CHASING)
            {
                agent.speed = chaseSpeed;
            }
            state = State.CHASING;
        }

        if (transform.position == target.transform.position)
        {
            randomizeTarget();
            if (state != State.SEARCHING)
            {
                agent.speed = searchSpeed;
            }
            state = State.SEARCHING;
        }
        
        
        agent.SetDestination(target.transform.position);
    }

    public bool playerVisible()
    {
        if (player == null) return false;
        
        Vector3 direction = (player.transform.position - transform.position).normalized;
        float distance = Vector3.Distance(transform.position, player.transform.position);

        
        if (Physics.Raycast(transform.position, direction, out RaycastHit hit, distance))
        {
            if (debugRay)
            {
                Debug.DrawRay(transform.position, direction * distance, Color.red);
                Debug.DrawRay(transform.position, direction * (Vector3.Distance(transform.position, hit.transform.position)), Color.green);
            }

            if (hit.transform == player.transform)
            {
                return true;
            }
        }
        
        return false;
    }

    private void randomizeTarget()
    {
        agent.SetDestination(randomTargets[Random.Range(0, randomTargets.Length)].transform.position);
    }

}
