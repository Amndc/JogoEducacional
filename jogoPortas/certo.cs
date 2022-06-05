using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class certo : MonoBehaviour
{
    public int contador;

    public GameObject acertou;
    public GameObject porta1;
    public GameObject porta2;
    public GameObject porta3;
    public GameObject porta4;

    public GameObject op1;
    public GameObject op2;
    public GameObject op3;
    public GameObject op4;

    public GameObject trofeu;
    public GameObject trofeuimg;


    public GameObject pergunta1;
    public GameObject placa1;
    public GameObject pergunta2;
    public GameObject placa2;
    public GameObject pergunta3;
    public GameObject placa3;
    public GameObject pergunta4;
    public GameObject placa4;

    public GameObject PlacaResposta1;
    public GameObject PlacaResposta11;
    public GameObject PlacaResposta111;
    public GameObject PlacaResposta1111;

    public GameObject PlacaResposta2;
    public GameObject PlacaResposta22;
    public GameObject PlacaResposta222;
    public GameObject PlacaResposta2222;

    public GameObject PlacaResposta3;
    public GameObject PlacaResposta33;
    public GameObject PlacaResposta333;
    public GameObject PlacaResposta3333;

    public GameObject PlacaResposta4;
    public GameObject PlacaResposta44;
    public GameObject PlacaResposta444;
    public GameObject PlacaResposta4444;

    public GameObject ImagePort1;
    public GameObject ImagePort12;
    public GameObject ImagePort13;
    public GameObject ImagePort14;

    public GameObject ImagePort2;
    public GameObject ImagePort22;
    public GameObject ImagePort23;
    public GameObject ImagePort24;

    public GameObject ImagePort3;
    public GameObject ImagePort32;
    public GameObject ImagePort33;
    public GameObject ImagePort34;

    public GameObject ImagePort4;
    public GameObject ImagePort42;
    public GameObject ImagePort43;
    public GameObject ImagePort44;


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
            acertou.SetActive(true);
            contador++;

            if (contador == 1)
            {
                PlacaResposta1.SetActive(false);
                PlacaResposta11.SetActive(false);
                PlacaResposta111.SetActive(false);
                PlacaResposta1111.SetActive(false);
                ImagePort1.SetActive(false);
                ImagePort2.SetActive(false);
                ImagePort3.SetActive(false);
                ImagePort4.SetActive(false);
                pergunta1.SetActive(false);
                placa1.SetActive(false);
                placa2.SetActive(true);
                ImagePort12.SetActive(true);
                ImagePort22.SetActive(true);
                ImagePort32.SetActive(true);
                ImagePort42.SetActive(true);
            }
            else if (contador == 2)
            {
                PlacaResposta2.SetActive(false);
                PlacaResposta22.SetActive(false);
                PlacaResposta222.SetActive(false);
                PlacaResposta2222.SetActive(false);
                ImagePort12.SetActive(false);
                ImagePort22.SetActive(false);
                ImagePort32.SetActive(false);
                ImagePort42.SetActive(false);
                pergunta2.SetActive(false);
                placa2.SetActive(false);
                placa3.SetActive(true);
                ImagePort13.SetActive(true);
                ImagePort23.SetActive(true);
                ImagePort33.SetActive(true);
                ImagePort43.SetActive(true);
            }
            else if (contador == 3)
            {
                PlacaResposta3.SetActive(false);
                PlacaResposta33.SetActive(false);
                PlacaResposta333.SetActive(false);
                PlacaResposta3333.SetActive(false);
                ImagePort13.SetActive(false);
                ImagePort23.SetActive(false);
                ImagePort33.SetActive(false);
                ImagePort43.SetActive(false);
                pergunta3.SetActive(false);
                placa3.SetActive(false);
                placa4.SetActive(true);
                ImagePort14.SetActive(true);
                ImagePort24.SetActive(true);
                ImagePort34.SetActive(true);
                ImagePort44.SetActive(true);
            }
            else if (contador == 4)
            {
                PlacaResposta4.SetActive(false);
                PlacaResposta44.SetActive(false);
                PlacaResposta444.SetActive(false);
                PlacaResposta4444.SetActive(false);
                ImagePort14.SetActive(false);
                ImagePort24.SetActive(false);
                ImagePort34.SetActive(false);
                ImagePort44.SetActive(false);
                pergunta4.SetActive(false);
                placa4.SetActive(false);
                porta1.SetActive(false);
                porta2.SetActive(false);
                porta3.SetActive(false);
                porta4.SetActive(false);
                op1.SetActive(false);
                op2.SetActive(false);
                op3.SetActive(false);
                op4.SetActive(false);
                trofeu.SetActive(true);
                trofeuimg.SetActive(true);
                
            }
            
        }
        


    }
}
