using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Estab : MonoBehaviour
{
    public void Mapa(){
        SceneManager.LoadScene(2);
    }

    public void Anotacoes(){
        SceneManager.LoadScene(11);
    }
}
