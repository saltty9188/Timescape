using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BossStatus : MonoBehaviour
{

    #region  Inspector fields
    [SerializeField] private float maxHealth = 500;
    [SerializeField] private Slider healthBar;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private Door exit;
    [SerializeField] private GameObject player;
    #endregion

    #region Private fields
    private float health;
    private DamageFlash flashScript;
    #endregion

    void Start()
    {
        flashScript = GetComponent<DamageFlash>();
        health = maxHealth;
        UpdateUI();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        UpdateUI();
        flashScript.Flash();
        if(health < 1) Die();
    }

    public void Die()
    {
        ThirdBossScript tbs = GetComponent<ThirdBossScript>();
        if(tbs)
        {
            tbs.SetDoorsClosed();
        }

        health = 0;
        Destroy(gameObject);
        healthBar.transform.parent.gameObject.SetActive(false);
        exit.AddActivation();
        if(player) player.GetComponent<Recorder>().CancelRecording();
    }

    public void ResetStatus()
    {
        health = maxHealth;
        UpdateUI();
        healthBar.transform.parent.gameObject.SetActive(false);
    }

    void UpdateUI()
    {
        if(healthBar != null) healthBar.value = health/maxHealth * 100.0f;
        if(healthText != null) healthText.text = ((int) health < 0 ? "0" : ((int) health).ToString());
    }
}