using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questPanel : MonoBehaviour
{
    [SerializeField] private GameObject QuestPanel;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            QuestPanel.SetActive(!QuestPanel.activeSelf);

            if (QuestPanel.activeSelf)
            {
                showMouse();
            }
            else {
                hideMouse();
                 }

        }
    }
    public void showMouse()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }
    public void hideMouse()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
