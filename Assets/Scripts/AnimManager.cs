using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimManager : MonoBehaviour
{
    private Animator mAnimator;

    bool canMoveState = false;

    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
        Debug.Log($"The animator holder is {mAnimator.gameObject.name}");
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.P))
        {
            mAnimator.Play("RotateAndScale");
        }*/

        if (Input.GetKeyDown(KeyCode.M))
        {
            canMoveState = !canMoveState;
            Debug.Log($"Can Move State value : {canMoveState}");

            mAnimator.SetBool("canMove", canMoveState);
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            mAnimator.SetTrigger("TriggerRotate");
        }
    }
}
