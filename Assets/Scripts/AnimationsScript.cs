using System.Collections;
using UnityEngine;

public class AnimationsScript : MonoBehaviour
{
    Animator anim;
    public GameObject navaja;

    void Start()
    {
        anim = GetComponent<Animator>();
        navaja.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) 
        { 
            anim.SetTrigger("walk");
        }else if (Input.GetKeyUp(KeyCode.W) && (anim.GetCurrentAnimatorStateInfo(0).IsName("caminar") || anim.GetCurrentAnimatorStateInfo(0).IsName("correr") || anim.GetCurrentAnimatorStateInfo(0).IsName("sigilo")))
        {
            anim.SetTrigger("idleloop");
        }else if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            anim.SetTrigger("run");
        }else if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            anim.SetTrigger("stealth");
        }else if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetTrigger("charge");
        }else if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            anim.SetTrigger("knife");
        }else if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            anim.SetTrigger("combat");
        }else if (Input.GetKeyDown(KeyCode.Q))
        {
            anim.SetTrigger("calibrate");
        }else if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            anim.SetTrigger("dodge");
        }else
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("combateConNavaja"))
            {
                navaja.SetActive(true);
            }
            else
            {
                navaja.SetActive(false);
            }
            anim.SetTrigger("idle");
        }
    }
}
