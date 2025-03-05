using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Animator ani;

    void Start()
    {
        //Pak het animator component en sla die op in de variabele
        ani = GetComponent<Animator>();
    }
    void Update()
    {
        //Check voor verticale input
        if (Input.GetAxis("Vertical") > 0)
        {
            //is de waarde groter dan 0 dan heb je een knop naar boven ingedrukt
            //Roep de juiste trigger aan!
            ani.SetTrigger("Run");
            //SetTrigger is trigger activeren
            ani.ResetTrigger("Idle");
            ani.ResetTrigger("RunR");
            //ResetTrigger is Trigger de-activeren
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            //is de waarde kleiner dan 0 dan heb je een knop naar beneden ingedrukt
            //Roep de juiste trigger aan
            ani.SetTrigger("RunR");
            ani.ResetTrigger("Idle");
            ani.ResetTrigger("Run");
        }
        else
        {
            //is de waarde 0 dan heb je niets ingedrukt
            //Roep de juiste trigger aan
            ani.SetTrigger("Idle");
            ani.ResetTrigger("Run");
            ani.ResetTrigger("RunR");
        }
    }
}
