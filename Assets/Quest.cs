using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{
    public Quest quest;
    public PlayerMovements player;

    public GameObject questWindow;
    public Text title;
    public Text description;
    public Text Experience;

    public void OpenQuestWindow()
    {
        questWindow.SetActive(true);
        title.text = quest.title.ToString();
        description.text = quest.description.ToString();
        Experience.text = quest.Experience.ToString();
    }
    public void AcceptQuiz()
    {
        questWindow.SetActive(false);
        //quest.isActive = true;
        //player.quest = quest;

    }

}

