using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    public Dialogo dialogo;

    public void TriggerDialogo()
    {
        FindObjectOfType<Gerec2>().StartDialogo(dialogo);
        FindObjectOfType<BalaoDeFala>().OnMouseDown();
    }
}
