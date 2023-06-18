using System;
using System.Transactions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private int tempo=24;
    private int caso;
    public static GameController instance;
    // Start is called before the first frame update
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
        tempo = instance.tempo;
    }
    
    public void Acao(int gasto){
        tempo -= gasto;
    }

    public void SetCaso(int missao){
        caso = missao;
    }

    public int GetCaso(){
        return caso;
    }

    public int GetTempo(){
        return tempo;
    }
}
