using System;
using System.Threading;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMap : MonoBehaviour{
    public void Delegacia(){
        SceneManager.LoadScene(12);
        if(CenaManager.instance.GetCena()!=12){ GameController.instance.Acao(1);}
        CenaManager.instance.SetCena(12);
    }

    public void Banco(){
        SceneManager.LoadScene(3);
        if(CenaManager.instance.GetCena()!=3) {GameController.instance.Acao(1);}
        CenaManager.instance.SetCena(3);
    }

    public void Bar(){
        SceneManager.LoadScene(4);
        if(CenaManager.instance.GetCena()!=4) {GameController.instance.Acao(1);}
        CenaManager.instance.SetCena(4);
    }

    public void Estacao(){
        SceneManager.LoadScene(5);
        if(CenaManager.instance.GetCena()!=5) {GameController.instance.Acao(1);}
        CenaManager.instance.SetCena(5);
    }

    public void Farmacia(){
        SceneManager.LoadScene(6);
        if(CenaManager.instance.GetCena()!=6) {GameController.instance.Acao(1);}
        CenaManager.instance.SetCena(6);
    }

    public void Floricultura(){
        SceneManager.LoadScene(7);
        if(CenaManager.instance.GetCena()!=7) {GameController.instance.Acao(1);}
        CenaManager.instance.SetCena(7);
    }

    public void Hotel(){
        SceneManager.LoadScene(8);
        if(CenaManager.instance.GetCena()!=8) {GameController.instance.Acao(1);}
        CenaManager.instance.SetCena(8);
    }

    public void Igreja(){
        SceneManager.LoadScene(9);
        if(CenaManager.instance.GetCena()!=9) {GameController.instance.Acao(1);}
        CenaManager.instance.SetCena(9);
    } 
    
    public void Restaurante(){
        SceneManager.LoadScene(10);
        if(CenaManager.instance.GetCena()!=10) {GameController.instance.Acao(1);}
        CenaManager.instance.SetCena(10);
    }

    public void Anotacoes(){
        SceneManager.LoadScene(11);
    }

    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
