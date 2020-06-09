using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionController : MonoBehaviour
{   
    public bool Walking = false;
    public Animator Anim;
    public float MoveSpeed = 2f;
    public float TurnSpeed = 50f;


    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Motion();
    }

    public void Motion(){
        if(Input.GetKey(KeyCode.W)){
            Anim.SetBool("Walking",true);
            transform.Translate(Vector3.forward *MoveSpeed *Time.deltaTime);

        }if(Input.GetKey(KeyCode.S)){
            Anim.SetBool("Walking",true);
            transform.Translate(-Vector3.forward *MoveSpeed *Time.deltaTime);

        }if(Input.GetKey(KeyCode.D)){
            Anim.SetBool("Walking",true);
            transform.Rotate(Vector3.up, TurnSpeed *Time.deltaTime);

        }if(Input.GetKey(KeyCode.A)){
            Anim.SetBool("Walking",true);
            transform.Rotate(Vector3.up, -TurnSpeed *Time.deltaTime);
        }
        else{
            Anim.SetBool("Walking",false);
        }

    }
}
