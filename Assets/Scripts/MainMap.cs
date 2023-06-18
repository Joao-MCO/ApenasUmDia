using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
}
