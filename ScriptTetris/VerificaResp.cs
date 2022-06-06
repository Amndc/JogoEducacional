using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VerificaResp : MonoBehaviour
{
    [SerializeField]
    public InputField resp;

    [SerializeField]
    public GameObject pergunta;

    

    public void verifica()
    {
        if (resp.text == "vogais")
        {
            pergunta.SetActive(false);
           

        }
    }




}
