using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestGoal : MonoBehaviour
{
    public GoalType goalType;

    public int requiredAmount;
    public int currentAmount;

    public bool IsReached()
    {
        return (currentAmount >= requiredAmount);
    }
    public enum GoalType
    {
        collect,
        gather
    }
}
