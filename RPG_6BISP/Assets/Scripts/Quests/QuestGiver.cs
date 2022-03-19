using System;
using System.Collections;
//using system.collections;
//using system.collections.generic;
//using unityengine;
using UnityEngine;

namespace RPG.Quests
{
    public class QuestGiver : MonoBehaviour
    {
         [SerializeField] Quest quest;

         public void GiveQuest()
         {
            QuestList questList = GameObject.FindGameObjectWithTag("Player").GetComponent<QuestList>();
            questList.AddQuest(quest);
         }

    }

}