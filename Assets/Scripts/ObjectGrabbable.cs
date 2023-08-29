using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGrabbable : MonoBehaviour
{

    private Rigidbody objectRigidbody;
    private Transform objectGrabPointTransform;
    public GameObject objetoADestruir;

    private void Awake(){
        objectRigidbody = GetComponent<Rigidbody>();
        }
    

    public void Grab(Transform objetGrabPointTransform)
    {
        this.objectGrabPointTransform = objetGrabPointTransform;
        objectRigidbody.useGravity = false;
        objectRigidbody.isKinematic = true;
    }

    public void Drop(){
        //this.objectGrabPointTransform = null;
        //objectRigidbody.useGravity = true;
        //objectRigidbody.isKinematic = false;
        Destroy(objetoADestruir);

    }

    private void FixedUpdate(){
        if(objectGrabPointTransform != null){
            float lerpSpeed = 10f;
            Vector3 newPosition = Vector3.Lerp(transform.position, objectGrabPointTransform.position, Time.deltaTime + lerpSpeed);
            objectRigidbody.MovePosition(newPosition);
        }
    }
}


