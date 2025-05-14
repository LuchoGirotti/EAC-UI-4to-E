using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class CalculadoraPoI : MonoBehaviour
{
    public int num1;
    public TMP_InputField inputNum1;
    public TextMeshProUGUI textResultado;

    // Start is called before the first frame update
    void Start()
    {
        textResultado.text = "";
        Debug.Log("Loaded!");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CalcularPoI()
    {
        num1 = int.Parse(inputNum1.text);
        Debug.Log(num1);

        if (num1 % 2 == 0)
        {
            textResultado.text = "Par";
            Debug.Log("par");

        }
        else
        {
            textResultado.text = "Impar";
            Debug.Log("imp");

        }
    }

}
