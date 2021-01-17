using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    int isRunningHash;
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
    }

    void Update()
    {
        bool forwardPressed = Input.GetKey("w");
        bool isWalking = animator.GetBool(isWalkingHash);
        bool runPressed = Input.GetKey("left shift");
        bool isRunning = animator.GetBool(isRunningHash);
        
        if(!isWalking && forwardPressed){
            animator.SetBool(isWalkingHash, true);
        }

        if(isWalking && !forwardPressed){
            animator.SetBool(isWalkingHash, false);
        }

        if(!isRunning && (forwardPressed && runPressed)){
            animator.SetBool(isRunningHash, true);
        }

        if(isRunning && (!forwardPressed || !runPressed)){
            animator.SetBool(isRunningHash, false);
        }
    }
}
