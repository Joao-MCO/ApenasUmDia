using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    public static TextManager instance;
    public TMP_Text hora;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        hora.text = GameController.instance.GetTempo().ToString() + "h";
    }
}
