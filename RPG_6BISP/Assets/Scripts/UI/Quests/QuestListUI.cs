using System.Collections;
using System.Collections.Generic;
using RPG.Quests;
using UnityEngine;

public class QuestListUI : MonoBehaviour
{
    [SerializeField] Quest[] tempQuests;
    [SerializeField] QuestItemUI questPrefab;
    //QuestList questList;

    // Start is called before the first frame update
    //void Start()
    //{
    //    questList = GameObject.FindGameObjectWithTag("Player").GetComponent<QuestList>();
    //    questList.onUpdate += Redraw;
    //    Redraw();
    //}

       void Start()
       {
        //foreach (Transform item in transform)
        //{
        //   Destroy(item.gameObject);
        //}
        transform.DetachChildren();
        foreach (Quest quest in tempQuests)
        {
            QuestItemUI uiInstance = Instantiate<QuestItemUI>(questPrefab, transform);
            uiInstance.Setup(quest);
        }
    }
}
