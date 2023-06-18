using System.Threading;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMap : MonoBehaviour
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
    public int missao;

    // Start is called before the first frame update
    void Start()
    {
        VerificaMissao();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Delegacia(){
        SceneManager.LoadScene(12);
    }

    public void Banco(){
        SceneManager.LoadScene(3);
    }

    public void Bar(){
        SceneManager.LoadScene(4);
    }

    public void Estacao(){
        SceneManager.LoadScene(5);
    }

    public void Farmacia(){
        SceneManager.LoadScene(6);
    }

    public void Floricultura(){
        SceneManager.LoadScene(7);
    }

    public void Hotel(){
        SceneManager.LoadScene(8);
    }

    public void Igreja(){
        SceneManager.LoadScene(9);
    } 
    
    public void Restaurante(){
        SceneManager.LoadScene(10);
    }

    public void Anotacoes(){
        SceneManager.LoadScene(11);
    }

    private void VerificaMissao(){
        if(missao==1){
            banco.interactable = true;
            bar.interactable = true;
            estacao.interactable = false;
            farmacia.interactable = false;
            floricultura.interactable = true;
            hotel.interactable = true;
            igreja.interactable = true;
            restaurante.interactable = false;
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
