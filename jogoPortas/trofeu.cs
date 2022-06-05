using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trofeu : MonoBehaviour
{

    public GameObject sair;
    public GameObject sair1;
    public GameObject trofeu1;
    public GameObject trofeu2;
    public GameObject msgTrofeu;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        //Por layer do objeto
        if (collision.gameObject.CompareTag("Player"))
        {
            sair.SetActive(true);
            sair1.SetActive(true);
            trofeu1.SetActive(false);
            trofeu2.SetActive(false);
            msgTrofeu.SetActive(true);
        }
    }

}
