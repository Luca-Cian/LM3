using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{

[SerializeField] private Transform playerCameraTransform;
[SerializeField] private LayerMask pickUpLayerMask;
[SerializeField] private Transform objectGrabPointTransform;


 private ObjectGrabbable objectGrabbable;
 private void Update() {
   if(Input.GetMouseButtonDown(0)){
      if(objectGrabbable == null){

     float pickUpDistance = 2f;
     if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, pickUpDistance, pickUpLayerMask)){
        if(raycastHit.transform.TryGetComponent(out objectGrabbable)){
            objectGrabbable.Grab(objectGrabPointTransform);
            Debug.Log(objectGrabbable);
        }
     }
    } else {
        objectGrabbable.Drop();
        objectGrabbable = null;
    }
   }

 }

}



