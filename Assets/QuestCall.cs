using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestCall : MonoBehaviour
{
    // Start is called before the first frame update
    public int tasks = 5; //health
    public int exp = 40; //exp

    public Quest quest;

    public void go()
    {
        tasks -= 5;
        exp += 2;
    }
}
