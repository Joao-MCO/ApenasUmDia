using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissaoManager : MonoBehaviour
{
    public Button banco;
    public Button bar;
    public Button estacao;
    public Button farmacia;
    public Button floricultura;
    public Button hotel;
    public Button igreja;
    public Button restaurante;
    public Button delegacia;
    public Button anotacoes;
    private int caso;
    public MissaoManager instance;

    private void Awake() {

        if (instance == null) {
            instance = this;
        }
        else{
            Destroy(gameObject, 2f);
            return;
        }
        
        DontDestroyOnLoad(gameObject);
        instance = this;
        caso = GameController.instance.GetCaso();
        VerificaMissao();
    }
    
    private void VerificaMissao(){
        if(caso==1){
            banco.interactable = true;
            bar.interactable = false;
            estacao.interactable = true;
            farmacia.interactable = false;
            floricultura.interactable = true;
            hotel.interactable = true;
            igreja.interactable = true;
            restaurante.interactable = true;
        }else{
            banco.interactable = true;
            bar.interactable = true;
            estacao.interactable = true;
            farmacia.interactable = true;
            floricultura.interactable = true;
            hotel.interactable = true;
            igreja.interactable = true;
            restaurante.interactable = true;
        }
    }
}
