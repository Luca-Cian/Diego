using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatFollowBehaviour : StateMachineBehaviour
{   
    
    //Variables para que vuelva después de tocar el suelo
    [SerializeField] private float distanciaSuelo;
    

    
    
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private Animator animator;
    [SerializeField] private float posOg;

    

    private Transform jugador;

    private Bat bat;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        jugador = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        bat = animator.gameObject.GetComponent<Bat>();
        posOg = animator.transform.position.y;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.transform.position = Vector2.MoveTowards(animator.transform.position, new Vector2(animator.transform.position.x,posOg-10), velocidadMovimiento*Time.deltaTime);
        
           RaycastHit2D informacionSuelo = Physics2D.Raycast(animator.transform.position, Vector2.down, distanciaSuelo); 
        
        if (informacionSuelo)
        {
            animator.SetTrigger("Volver");
            Debug.Log("volver");
        } 


    }   
    

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }

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
}
