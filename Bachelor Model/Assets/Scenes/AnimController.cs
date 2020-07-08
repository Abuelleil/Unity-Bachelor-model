using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    public bool Walking = false;
    public bool Running = false;
    public bool Combat = false;
    public bool ClenchIndex = false;
    public bool LeftClench = false;    
    public bool TwoFistClench = false;
    public bool RightLegUp = false;
    public bool LeftLegUp = false;
    public bool Tasbi7 = false;
    public bool FingerGun = false;
    public bool ArmChair = false;
    public bool TwoLegs = false;
    public Animator Anim;
    public float MoveSpeed = 5f;
    public float RunSpeed = 25f;
    //public float TurnSpeed = 50f;


    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {    
        if(Input.GetKey(KeyCode.Z)){
            Anim.SetTrigger("TwoFistClench");
            // TwoFistClench = !TwoFistClench;
            // Anim.SetBool("TwoFistClench",TwoFistClench);
        } 
         if(Input.GetKey(KeyCode.M)){ 
            Anim.SetTrigger("LegMotion");
            // TwoLegs = !TwoLegs;
            // Anim.SetBool("TwoLegs",TwoLegs);
        }
        if(Input.GetKey(KeyCode.N)){
            Anim.SetTrigger("ArmChair");
            // ArmChair = !ArmChair;
            // Anim.SetBool("ArmChair",ArmChair);
        }
         if(Input.GetKey(KeyCode.B)){
            Anim.SetTrigger("FingerGun");
        //     FingerGun = !FingerGun;
        //     Anim.SetBool("FingerGun",FingerGun);
         }
         if(Input.GetKey(KeyCode.V)){
            Anim.SetTrigger("Tasbi7");
            // Tasbi7 = !Tasbi7;
            // Anim.SetBool("Tasbi7",Tasbi7);
        }
        if(Input.GetKey(KeyCode.C)){
            LeftLegUp = !LeftLegUp;
            Anim.SetBool("LeftLegUp",LeftLegUp);
        }
        if(Input.GetKey(KeyCode.X)){
            RightLegUp = !RightLegUp;
            Anim.SetBool("RightLegUp",RightLegUp);
        }
       
        if(Input.GetKey(KeyCode.D)){
            LeftClench = !LeftClench;
            Anim.SetBool("LeftClench",LeftClench);
        }
        if(Input.GetKey(KeyCode.A)){
            ClenchIndex = !ClenchIndex;
            Anim.SetBool("ClenchIndex",ClenchIndex);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            Combat = !Combat;
            Anim.SetBool("Combat",Combat);
        }
        if(Input.GetKey(KeyCode.W)){
            if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W)){
                Anim.SetBool("Running",true); 
                Anim.SetBool("Walking",true); 
                transform.Translate(Vector3.forward * RunSpeed * Time.deltaTime);
            }else{
            Anim.SetBool("Walking",true); 
            Anim.SetBool("Running",false); 
            transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
            }
        }
        else{
            Anim.SetBool("Walking",false);
        }
    }
}
