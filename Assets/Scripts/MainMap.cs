using System.Threading;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMap : MonoBehaviour
{
    
    // Vou deixar como padrão 1h, mas caso queira mudar, só fazer um IF
    public void Delegacia(){
        SceneManager.LoadScene(12);
        GameController.instance.Acao(1);
    }

    public void Banco(){
        SceneManager.LoadScene(3);
        GameController.instance.Acao(1);
    }

    public void Bar(){
        SceneManager.LoadScene(4);
        GameController.instance.Acao(1);
    }

    public void Estacao(){
        SceneManager.LoadScene(5);
        GameController.instance.Acao(1);
    }

    public void Farmacia(){
        SceneManager.LoadScene(6);
        GameController.instance.Acao(1);
    }

    public void Floricultura(){
        SceneManager.LoadScene(7);
        GameController.instance.Acao(1);
    }

    public void Hotel(){
        SceneManager.LoadScene(8);
        GameController.instance.Acao(1);
    }

    public void Igreja(){
        SceneManager.LoadScene(9);
        GameController.instance.Acao(1);
    } 
    
    public void Restaurante(){
        SceneManager.LoadScene(10);
        GameController.instance.Acao(1);
    }

    public void Anotacoes(){
        SceneManager.LoadScene(11);
        GameController.instance.Acao(1);
    }
}
