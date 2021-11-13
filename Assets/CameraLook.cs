using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class CameraLook : MonoBehaviour
{

    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float XRotaion = 0f;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void Update()
    {
        if(!IsMouseOverUI()){
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y")  * mouseSensitivity * Time.deltaTime;

        XRotaion -= mouseY;
        XRotaion = Mathf.Clamp(XRotaion, -90f, 90f);

        transform.localRotation = Quaternion.Euler(XRotaion, 0f ,0f);

        playerBody.Rotate(Vector3.up * mouseX);
        }


        
    }


    private bool IsMouseOverUI(){
            // Debug.Log("OvertheUI");
          return  EventSystem.current.IsPointerOverGameObject();
          
    }
}
