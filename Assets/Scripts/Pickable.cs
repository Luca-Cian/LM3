using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pickable : MonoBehaviour
{
    [SerializeField] private Soltarse progresoDeRotura;

    public bool mousePressed;
    public float requireHoldTime;
    private float timerMousePressed;
    private float nivelRotura;
    public bool canInteract;

    void Awake(){
        progresoDeRotura.InicializarProgreso(nivelRotura);
    }

    void OnMouseDown(){
        mousePressed = true;
        //Debug.Log("apretando");
    }

    void OnMouseUp(){
        mousePressed = false;
        //Debug.Log("soltaste");
    }

    void Update(){
        if(canInteract){
            if(mousePressed){
                timerMousePressed += Time.deltaTime;
                nivelRotura = timerMousePressed;
                Debug.Log(nivelRotura);
                progresoDeRotura.CambiarProgresoActual(nivelRotura);

                if(timerMousePressed >= requireHoldTime){
                    Destroy(gameObject);
                    Reset();
                }
            } else if(!mousePressed) {
                Reset();
            }
        }
    }

    /*public void canInteract(){
        if(timerMousePressed >= requireHoldTime){
            Destroy(gameObject);
            Reset();
        }
    }*/

    void Reset(){
        timerMousePressed = 0;
        progresoDeRotura.CambiarProgresoActual(0);
        canInteract = false;
    }
}
