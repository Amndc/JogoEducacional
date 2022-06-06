using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{

    [SerializeField]
    private Sprite _vidaCheia;

    [SerializeField]
    private Sprite _vidaVazia;

    [SerializeField]
    private GameObject _vida;

    private List<GameObject> _baterias = new List<GameObject>();



    public void AtualizaVida(int VidaAtual, int TotalVidas)
    {

        ResetaLista();

        for(int i = 0; i < TotalVidas; i++)
        {

            if (VidaAtual <=1)
            {
                _vida.GetComponent<Image>().sprite = _vidaVazia;
            }
            else
            {
                _vida.GetComponent<Image>().sprite = _vidaCheia;
            }
            var posXCalc = transform.position.x + (i * 50);
            var go = Instantiate(_vida, new Vector3(posXCalc, transform.position.y, 0), Quaternion.identity, this.transform);
            _baterias.Add(go); 
        
        
        }
    }

    private void ResetaLista()
    {
        foreach(var bateria in _baterias)
        {
            Destroy(bateria);
        }
    }
}
