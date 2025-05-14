using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class SumadorUI : MonoBehaviour
{
    public int num1;
    public int num2;
    public TMP_InputField inputNum1;
    public TMP_InputField inputNum2;
    public TextMeshProUGUI textResultado;

    // Start is called before the first frame update
    void Start()
    {
        textResultado.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SumarYMostrarResultado()
    {
        //tomar los valores del input y sumarlos
        num1 = int.Parse(inputNum1.text);
        num2 = int.Parse(inputNum2.text);

        textResultado.text = $"{num1 +num2}";
    }

}
