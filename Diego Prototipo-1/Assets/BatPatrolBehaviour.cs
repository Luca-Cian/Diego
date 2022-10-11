using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatPatrolBehaviour : StateMachineBehaviour
{

    [SerializeField] private float velocidad;
    [SerializeField] private float ditanciaRecorrido;
     
    private bool moviendoDerecha;
    private float posInicialx;

    private Bat bat;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        bat = animator.gameObject.GetComponent<Bat>();
        posInicialx = animator.transform.position.x;
        
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Mover(animator);
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
    private void Mover(Animator animator){
        animator.transform.position = Vector2.MoveTowards(animator.transform.position, new Vector2(animator.transform.position.x+ditanciaRecorrido, animator.transform.position.y), velocidad*Time.deltaTime);
    
        if(Mathf.Abs(animator.transform.position.x-posInicialx)>ditanciaRecorrido){
            Girar(animator);
        }
    
    }

    private void Girar(Animator animator){
            moviendoDerecha = !moviendoDerecha;
            animator.transform.eulerAngles = new Vector3(0, animator.transform.eulerAngles.y + 180,0);
            velocidad*=-1;
    }
}
