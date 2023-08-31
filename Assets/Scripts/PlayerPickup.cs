using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{

[SerializeField] private Transform playerCameraTransform;

public float rayDistance;

private void Update() {

  Debug.DrawRay(playerCameraTransform.position, playerCameraTransform.forward * rayDistance, Color.red);

   if(Input.GetMouseButtonDown(0)){
      if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, rayDistance, LayerMask.GetMask("Hilo"))){
        raycastHit.transform.GetComponent<Interactable>().Interact();
      }
   }
 }
}



