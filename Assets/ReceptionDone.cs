using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceptionDone : MonoBehaviour
{
    [SerializeField] private GameObject reception;
    [SerializeField] private GameObject QuestDialog;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            reception.SetActive(true);
            //QuestDialog.SetActive(true);
            QuestDialog.SetActive(true);
            Object.Destroy(QuestDialog, 2.0f);
            Destroy(this.gameObject);
            //StartCoroutine(ActivationRoutine());
        }

    }
    private void HideAndShow(float delay)
    {
        QuestDialog.SetActive(true);

        // Call Show after delay seconds
        Invoke(nameof(Show), delay);
    }

    private void Show()
    {
        QuestDialog.SetActive(false);
    }

}
