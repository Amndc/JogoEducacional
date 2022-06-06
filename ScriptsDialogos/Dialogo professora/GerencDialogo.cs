using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GerencDialogo : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI nomeText;

    [SerializeField]
    public TextMeshProUGUI dialogoText;

    public Animator anim;

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
        if(sentences.Count == 0)
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
    }

}
