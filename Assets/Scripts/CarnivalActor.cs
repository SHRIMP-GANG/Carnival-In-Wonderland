using UnityEngine;
using UnityEditor;
using System.Collections;
using UnityEngine.AI;

namespace EightDirectionalSpriteSystem
{
    [ExecuteInEditMode]
    public class CarnivalActor : MonoBehaviour
    {
        public enum State { NONE, IDLE, WALKING};

        public ActorBillboard actorBillboard;

        public ActorAnimation idleAnim;
        public ActorAnimation walkAnim;


        private Transform myTransform;
        private ActorAnimation currentAnimation = null;
        private State currentState = State.NONE;
        private NavMeshAgent agent;

        void Awake()
        {
            myTransform = GetComponent<Transform>();
        }

        void Start()
        {
            SetCurrentState(State.IDLE);
            agent = GetComponent<NavMeshAgent>();
        }

        private void OnEnable()
        {
            SetCurrentState(State.IDLE);
        }

        private void OnValidate()
        {
            if (actorBillboard != null && actorBillboard.CurrentAnimation == null)
                SetCurrentState(currentState);
        }

        void Update()
        {
            if (actorBillboard != null)
            {
                actorBillboard.SetActorForwardVector(myTransform.forward);
            }
            
            /*State nextState = currentState;

            if (agent.velocity.magnitude > 0.1f)
            {
                nextState = State.IDLE;
            }
            else
            {
                nextState = State.IDLE;
            }
            

            SetCurrentState(State.IDLE);*/
            
           
        }

        private void SetCurrentState(State newState)
        {
            currentState = newState;
            switch (currentState)
            {

                case State.WALKING:
                    currentAnimation = walkAnim;
                    break;

                default:
                    currentAnimation = idleAnim;
                    break;
            }

            if (actorBillboard != null)
            {
                actorBillboard.PlayAnimation(currentAnimation);
            }
        }

    }
}
