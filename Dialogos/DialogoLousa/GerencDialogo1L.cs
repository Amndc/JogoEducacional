﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GerencDialogo1L : MonoBehaviour
{


    [SerializeField]
    public TextMeshProUGUI nomeText;

    [SerializeField]
    public TextMeshProUGUI dialogoText;

    public Animator anim;

    [SerializeField]
    public GameObject Exp;

    private Queue<string> sentences;


    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogo(Dialogo dialogo)
    {
        anim.SetBool("IsOpen", true);
        nomeText.text = dialogo.nameNPC;

        sentences.Clear();

        foreach (string sentence in dialogo.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogo();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogoText.text = sentence;
    }

    void EndDialogo()
    {
        anim.SetBool("IsOpen", false);
        Exp.SetActive(true);

    }

}



