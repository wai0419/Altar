using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] private LayerMask PickupLayer;
    [SerializeField] private GameObject PlayerCamera;
    [SerializeField] private GameObject ес;

    [SerializeField] private float ThrowingForce;
    [SerializeField] private float PickupRange;
    [SerializeField] private Transform Hand;


    private Rigidbody CurrentObjectRigibody;

    private Collider CurrentObjectCollider;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(PlayerCamera.transform.position, PlayerCamera.transform.forward*2, Color.red);
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray Pickupray = new Ray(PlayerCamera.transform.position, PlayerCamera.transform.forward * 2);
            
            if (Physics.Raycast(Pickupray, out RaycastHit hitInfo, PickupRange, PickupLayer))
            {
                
                Debug.Log(PickupLayer);
                
                if (CurrentObjectRigibody)
                {

                    Debug.Log(PickupLayer);
                    CurrentObjectRigibody.isKinematic = false;
                    CurrentObjectCollider.enabled = true;

                    CurrentObjectRigibody = hitInfo.rigidbody;
                    CurrentObjectCollider = hitInfo.collider;
                    
                    CurrentObjectRigibody.isKinematic = true;
                    CurrentObjectCollider.enabled = false;

                    
                }
                else
                {
                    CurrentObjectRigibody = hitInfo.rigidbody;
                    CurrentObjectCollider = hitInfo.collider;

                    CurrentObjectRigibody.isKinematic = true;
                    CurrentObjectCollider.enabled = false;
                }
                return;
            }
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            if(CurrentObjectRigibody)
            {
                CurrentObjectRigibody.isKinematic = false;
                CurrentObjectCollider.enabled = true;

                CurrentObjectRigibody.AddForce(ес.transform.up* ThrowingForce, ForceMode.Impulse);

                CurrentObjectRigibody = null;
                CurrentObjectCollider = null;
            }
        }    
        if(CurrentObjectRigibody)
        {
            CurrentObjectRigibody.position = Hand.position;
            CurrentObjectRigibody.rotation = Hand.rotation;
        }
    }
}
