using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pickable : Interactable
{
    private bool mousePressed;
    public float requireHoldTime;
    private float timerMousePressed;

    [SerializeField]public ProgresoDeRotura progresoDeRotura;

    void Start(){
        progresoDeRotura.InicializarProgreso(timerMousePressed);
    }

    void OnMouseDown(){
        mousePressed = true;
        Debug.Log(timerMousePressed);
    }

    void Update(){
        if(mousePressed){
            timerMousePressed += Time.deltaTime;
        } else {
            Reset();
        }

        if(timerMousePressed >= requireHoldTime){
            Destroy(gameObject);
        }
    }

    public override void Interact(){
        base.Interact();
    }

    void Reset(){
        timerMousePressed = 0;
        mousePressed = false;
    }
}
