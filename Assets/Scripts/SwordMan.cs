using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMan : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        if(h>0){
            transform.localScale = new Vector3(-1,1,1);
        } else if(h<0){
            transform.localScale = new Vector3(1,1,1);
        }
        animator.SetBool("moving", h!=0);
        //Time.deltaTime : 1프레임 당 걸리는 시간
        transform.Translate(new Vector3(h,0,0) * Time.deltaTime);
    }
}
