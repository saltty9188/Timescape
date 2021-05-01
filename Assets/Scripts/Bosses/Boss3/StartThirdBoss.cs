using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartThirdBoss : MonoBehaviour
{
    #region Inspector fields
    [SerializeField] private ThirdBossScript bossScript;
    [SerializeField] private GameObject bossUI;
    [SerializeField] private RecordingDoor entrance;
    #endregion

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Clone")
        {
            bossScript.StartFight();
            bossUI.SetActive(true);
        }
        else if(other.tag == "Player")
        {
            bossScript.StartFight();
            bossUI.SetActive(true);
            entrance.SetInFight(true);
        }
    }
}