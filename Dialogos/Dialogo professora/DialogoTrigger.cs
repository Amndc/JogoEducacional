using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoTrigger : MonoBehaviour
{
    public Dialogo dialogo;

    public void TriggerDialogo()
    {
        FindObjectOfType<GerencDialogo>().StartDialogo(dialogo);
        FindObjectOfType<BalaoDeFala>().OnMouseDown();
    }

}
