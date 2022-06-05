using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[RequireComponent(typeof(Collider2D))]
public class InteragirComBotao : MonoBehaviour
{
    [SerializeField]
    private Jogador _Jogador;

    [SerializeField]
    private UnityEvent _botaoApertado;

    [SerializeField]

    private bool _podeExecutar;

    void update()
    {
        if (_podeExecutar && _Jogador.EstaInteragindo == true)
        {
            _botaoApertado.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _podeExecutar = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _podeExecutar = false;
    }
}
