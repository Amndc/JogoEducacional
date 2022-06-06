using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExp : MonoBehaviour
{
    public Dialogo dialogo;

    public void TriggerExplicacao()
    {
        FindObjectOfType<GerencExp>().StartDialogo(dialogo);  


    }
}
