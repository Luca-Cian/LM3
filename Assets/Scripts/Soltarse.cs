using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Soltarse : MonoBehaviour
{
    private Slider slider;

    void Awake(){
        slider = GetComponent<Slider>();
    }

    public void CambiarProgresoActual(float progresoActual){
        slider.value = progresoActual;
    }

    public void InicializarProgreso(float progresoInicial){
        CambiarProgresoActual(progresoInicial);
    }
}
