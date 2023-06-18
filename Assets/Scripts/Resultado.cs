using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Resultado : MonoBehaviour
{
    public void Voltar(){
        SceneManager.LoadScene(0);
        gameObject.SetActive(false);
        
    }
}
