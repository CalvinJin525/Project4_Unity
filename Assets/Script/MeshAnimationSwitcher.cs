using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshAnimationSwitcher : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool fastRun = Input.GetKey(KeyCode.R);
        bool walking = Input.GetKey(KeyCode.W);
        bool wallRun = Input.GetKey(KeyCode.A);

        animator.SetBool("IsFastRun", fastRun);
        animator.SetBool("IsWalking", walking);
        animator.SetBool("IsWallRun", wallRun);
    }
}
