using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{   private Animator animator;
    public string boolNew = "walking";
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            animator.SetBool(boolNew, true);
        }
        else
        {
            animator.SetBool(boolNew, false);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            animator.Play("Salto");
        }
    }
}
