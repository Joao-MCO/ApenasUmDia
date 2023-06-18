using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Investiga : MonoBehaviour
{
    public Button []botoes;
    public GameObject []paneis;
    public TMP_Text []dicas;
    public string []frases;
    private int acao;
    void Start()
    {
        acao = 1;
    }

    public void Gasta(int b){
        Visual(b);
        GameController.instance.Acao(acao);
        acao += 1;
    }

    public void Visual(int b){
        botoes[b].interactable = false;
        paneis[b].SetActive(true);
        dicas[b].text = frases[b];
    }
}
