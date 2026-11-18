using UnityEditor.Purchasing;
using UnityEngine;
using UnityEngine.AI;

public class VelveteenAI : MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject player;
    public GameObject target;

    public SpriteRenderer actor;

    private enum State { SPAWNED, DESPAWNED };
    private State state;

    private float timer = 0f;
    private Vector3 startPos = new Vector3(12.37f, 0f, -16.7f);


    public bool randomSpawn()
    {

        int randomInt = Random.Range(1, 7);

        if (randomInt == 6)
        {

            return true;
        }
        else
        {

            return false;
        }

    }



    public void getRandomPos()
    {
        Vector2 randomCircle;
        Vector3 offset;
        bool found = false;

        while (found == false)
        {

            randomCircle = Random.onUnitCircle * 50;

            offset = new Vector3(randomCircle.x, 0f, randomCircle.y);

            NavMeshHit hit;

            Debug.Log(offset);

            if (NavMesh.SamplePosition((player.transform.position + offset), out hit, 0.3f, NavMesh.AllAreas))
            {
                target.transform.position = player.transform.position + offset;

                found = true;
            }
        }
    }

    void Start()
    {

        agent = GetComponent<NavMeshAgent>();

        actor = GetComponentInChildren<SpriteRenderer>();

        actor.enabled = false;

        state = State.DESPAWNED;
    }

    void Update()
    {

        float timerLimit = 3f;

        timer += Time.deltaTime;

        // Debug.Log("timer: " + timer + " deltaTime: " + Time.deltaTime);

        if (timer >= timerLimit)
        {
            // Debug.Log("timer hit limit");


            if (randomSpawn() == true)
            {

                // Debug.Log("spawn true");

                if (state == State.DESPAWNED)
                {

                    state = State.SPAWNED;

                    transform.position = startPos;

                    getRandomPos();

                    actor.enabled = true;

                    agent.SetDestination(target.transform.position);

                }
                else
                {

                    agent.SetDestination(target.transform.position);

                }
            }
            else
            {

                if (state == State.SPAWNED)
                {

                    agent.SetDestination(target.transform.position);

                    if (!agent.pathPending)
                    {

                        if (agent.remainingDistance <= agent.stoppingDistance)
                        {

                            if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                            {

                                state = State.DESPAWNED;

                                actor.enabled = false;

                                // transform.position = startPos;

                                timer = 0f;

                            }
                        }
                    }

                }
                else if (state == State.DESPAWNED)
                {

                    timer = 0f;

                    // transform.position = startPos;
                }
            }

        }
    }
}
