using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenClose : MonoBehaviour
{

    public bool pause = true;

    [SerializeField]
    public GameObject Pausado;

    [SerializeField]
    public GameObject Confirm;

    public string fasePCarregar;

    public void Continue()
    {
        Pausado.SetActive(false);
        pause = false;
    }


    public void Sair()
    {
        Pausado.SetActive(false);
        Confirm.SetActive(true);     
    }
    
    public void ConfirmarS()
    {
        SceneManager.LoadScene(fasePCarregar);
    }

    public void ConfirmarN()
    {
        Pausado.SetActive(true);
    }


}
