using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightingChar : MonoBehaviour
{
    public KeyCode punchKeyCode;
    public KeyCode blockKeyCode;
    public GameObject characterObj;
    Animator ControllerAnim;
    public bool isBlocking;

    // Start is called before the first frame update
    void Start()
    {
        
        ControllerAnim = characterObj.GetComponent<Animator>();
        isBlocking = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(punchKeyCode))
        {
            Punch();
        }

        if (Input.GetKey(punchKeyCode)) 
        {
            isBlocking = true;
            ControllerAnim.SetBool("Blocking", isBlocking);
        }
        if (Input.GetKeyUp(punchKeyCode))
        {
            isBlocking = false;
            ControllerAnim.SetBool("Blocking", isBlocking);
        }
        if (Input.GetKeyDown(blockKeyCode))
        {
            isBlocking = true;
            ControllerAnim.SetBool("Blocking", isBlocking);
        }
        if (Input.GetKeyUp(blockKeyCode))
        {
            isBlocking = false;
            ControllerAnim.SetBool("Blocking", isBlocking);
        }
    }

    [ContextMenu("Attack")]

    public void Punch()
    {
        ControllerAnim.SetTrigger("Punching");
        isBlocking = false;
        ControllerAnim.SetBool("Blocking", isBlocking);
    }

    public void Block() 
    {
        if (isBlocking)
        {
            isBlocking = false;
        }
        else if (isBlocking)
        {
            isBlocking = true;
        }

        ControllerAnim.SetBool("Blocking", isBlocking);
    }
}
