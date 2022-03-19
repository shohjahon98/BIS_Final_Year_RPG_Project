﻿using System;
using System.Collections;
using System.Collections.Generic;
using GameDevTV.Inventories;
using GameDevTV.Utils;
using UnityEngine;

namespace RPG.Quests
{
    [CreateAssetMenu(fileName = "Quest", menuName = "RPG_6BISP/Quest", order = 0)]
    public class Quest : ScriptableObject
    {
        
        [SerializeField] List<string> objectives = new List<string>();
        //[SerializeField] List<Reward> rewards = new List<Reward>();

        //[System.Serializable]
        //public class Reward
        //{
        //    [Min(1)]
        //    public int number;
        //    public InventoryItem item;
        //}

        //[System.Serializable]
        //public class Objective
        //{
        //    public string reference;
        //    public string description;
        //    public bool usesCondition = false;
        //    public Condition completionCondition;
        //}

         public string GetTitle()
         {
             return name;
         }

         public int GetObjectiveCount()
         {
             return objectives.Count;
         }

          public IEnumerable<string> GetObjectives()
          {
             return objectives;
          }

        //public IEnumerable<Reward> GetRewards()
        //{
        //    return rewards;
        //}

        public bool HasObjective(string objective)
        {
            return objectives.Contains(objective);
            //foreach (var objective in objectives)
            //{
            //    if (objective.reference == objectiveRef)
            //    {
            //        return true;
            //    }
            //}
            //return false;
        }

        //public static Quest GetByName(string questName)
        //{
        //    foreach (Quest quest in Resources.LoadAll<Quest>(""))
        //    {
        //        if (quest.name == questName)
        //        {
        //            return quest;
        //        }
        //    }
        //    return null;
        //}

    }
}