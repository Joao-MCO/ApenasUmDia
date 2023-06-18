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
        botoes[b].interactable = false;
        paneis[b].SetActive(true);
        GameController.instance.Acao(acao);
        acao += 1;
    }
}