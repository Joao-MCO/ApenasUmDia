using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Confirmacao : MonoBehaviour
{
    public TMP_Text resultado;
    public TMP_Text descricao;
    public string []discurso;
    public GameObject resulPanel;

    public void Nao(){
        gameObject.SetActive(false);
    }

    public void Sim(TMP_Text nome){
        if(nome.text == "Anne Lis"){
            resultado.text = "SUCESSO";
            descricao.text = discurso[0];
        }else{
            resultado.text = "FRACASSO";
            descricao.text = discurso[1];
        }
        resulPanel.SetActive(true);
    }
}
