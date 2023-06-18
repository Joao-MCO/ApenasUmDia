using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenaManager : MonoBehaviour
{

    public static CenaManager instance;
    private int cena;
    
    void Awake()
    {
        if (instance == null) {
            instance = this;
        }
        else{
            Destroy(gameObject, 2f);
            return;
        }
        
        DontDestroyOnLoad(gameObject);

        instance = this;
        cena = -1;
    }

    public void SetCena(int c){
        cena = c;
    }

    public int GetCena(){
        return cena;
    }
}
