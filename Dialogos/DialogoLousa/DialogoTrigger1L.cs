using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoTrigger1L : MonoBehaviour
{
    public Dialogo dialogo;

    public void TriggerDialogo()
    {
        FindObjectOfType<GerencDialogo1L>().StartDialogo(dialogo);

    }
}
