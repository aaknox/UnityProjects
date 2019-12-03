using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DownBehavior : StateMachineBehaviour
{
    private Transform playerPos;
    public float speed;
    public TextMeshProUGUI levelNumber;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        playerPos = GameObject.Find("Player").transform;
        levelNumber = GameObject.Find("LevelCounter").GetComponent<TextMeshProUGUI>();
        
        int num = int.Parse(levelNumber.text);
        if (num >= 4)
        {
            speed = 0.5f;
            Debug.Log("Enemy speed reduced.");
        }
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        

        //down
        if ((playerPos.position.y - animator.transform.position.y) <= 0)
        {
            animator.SetBool("isDown", true);
            animator.transform.position = Vector2.MoveTowards(animator.transform.position, playerPos.position, speed * Time.deltaTime);
        }
        //up
        if ((playerPos.position.y - animator.transform.position.y) > 0)
        {
            animator.SetBool("isUp", true);
            animator.transform.position = Vector2.MoveTowards(animator.transform.position, playerPos.position, speed * Time.deltaTime);
        }
        //left
        if ((playerPos.position.x - animator.transform.position.x) <= 0)
        {
            animator.SetBool("isLeft", true);
            animator.transform.position = Vector2.MoveTowards(animator.transform.position, playerPos.position, speed * Time.deltaTime);
        }

        //right
        if ((playerPos.position.x - animator.transform.position.x) > 0)
        {
            animator.SetBool("isRight", true);
            animator.transform.position = Vector2.MoveTowards(animator.transform.position, playerPos.position, speed * Time.deltaTime);
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
