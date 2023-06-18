using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Suspeitos : MonoBehaviour
{
    public TMP_Text textConfirm;
    public GameObject panelConfirm;
    public void Palpite(TMP_Text texto){
        textConfirm.text = texto.text;
        panelConfirm.SetActive(true);
    }
}
