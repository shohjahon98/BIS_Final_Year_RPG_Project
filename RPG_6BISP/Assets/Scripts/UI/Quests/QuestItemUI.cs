using System.Collections;
using System.Collections.Generic;
using RPG.Quests;
using TMPro;
using UnityEngine;

public class QuestItemUI : MonoBehaviour
{
     [SerializeField] TextMeshProUGUI title;
     [SerializeField] TextMeshProUGUI progress;
    Quest quest;

//    QuestStatus status;

     public void Setup(Quest quest)
     {
        this.quest = quest;
        title.text = quest.GetTitle();
        progress.text = "0/" + quest.GetObjectiveCount();
         //this.status = status;
         //title.text = status.GetQuest().GetTitle();
         //progress.text = status.GetCompletedCount() + "/" + status.GetQuest().GetObjectiveCount();
     }
    public Quest GetQuest()
    {
        return quest;
    }


//    public QuestStatus GetQuestStatus()
//    {
//        return status;
//    }
}
