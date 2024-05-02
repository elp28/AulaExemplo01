using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Andar : MonoBehaviour
{

    public float velocidade = 10f;

    void Update()
    {
        float movimentoVertical = Input.GetAxis("Vertical");
        float movimentoHorizontal = Input.GetAxisRaw("Horizontal");

        Vector3 movimento = new Vector3(movimentoHorizontal, 0) * velocidade * Time.deltaTime;
        transform.Translate(movimento);

    }
}





