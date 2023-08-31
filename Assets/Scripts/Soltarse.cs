using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Soltarse : MonoBehaviour
{
    private Slider slider;

    private void Start(){
        slider = GetComponent<Slider>();
    }

    public void CambiarProgreso(float nivelSoltado){
        slider.maxValue = nivelSoltado;
    }

    public void CambiarProgresoActual(float progresoActual){
        slider.value = progresoActual;
    }

    public void InicializarProgreso(float progresoInicial){
        CambiarProgreso(progresoInicial);
        CambiarProgresoActual(progresoInicial);
    }
}
