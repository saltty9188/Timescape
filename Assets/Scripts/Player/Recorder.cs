using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Recorder : MonoBehaviour
{

    #region Inspector fields
    [SerializeField] private TimeCloneController timeCloneController;
    [SerializeField] private EnemyManager enemyManager;
    [SerializeField] private GameObject recordingIcon;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private GameObject events;
    #endregion

    #region Public fields
    public bool IsRecording
    {
        get{return recording;}
    }
    #endregion

    #region Private fields
    private Aim aim;
    private TimeCloneDevice activeCloneMachine;
    private List<RecordedCommand> commands;
    private bool recording;
    private Vector3 recordingStartPos;
    private Weapon startingWeapon;
    private float accumulatedTime;
    private float timer;
    #endregion

    void Start()
    {
        aim = transform.GetChild(0).GetComponent<Aim>();
        recording = false;
        commands = new List<RecordedCommand>();
        accumulatedTime = 0;
        timer = 0;
    }

    void Update()
    {
        if(timer > 0) 
        {
            timer -= Time.deltaTime;
            UpdateTimerText();
        }
        else if(recording)
        {
            recording = false;
            StopRecording();
            GetComponent<PlayerController>().RecordingCancelled();
        } 
    }

    public void StartRecording(TimeCloneDevice nearbyCloneMachine, Weapon weapon)
    {
        recording = true;
        PhysicsObject.UpdateAllInitialPositions();
        recordingStartPos = transform.position;
        activeCloneMachine = nearbyCloneMachine;
        startingWeapon = weapon;
        timer = 60;

        timeCloneController.PlayBack(activeCloneMachine);
        if(enemyManager) enemyManager.CacheEnemyInfo();
        WeaponManager.SetDefaultPosition();
        recordingIcon.SetActive(true);
        UpdateTimerText();

        if(startingWeapon != null)
        {
            if(typeof(PhysicsRay).IsInstanceOfType(weapon))
            {
                PhysicsRay pr = (PhysicsRay) weapon;
                pr.SetStartingType();
            }
        }
    }

    public void StopRecording()
    {
        recording = false;
        accumulatedTime = 0;
        transform.position = recordingStartPos;
        timer = 0;

        GameObject endingWeapon = (aim.CurrentWeapon ? aim.CurrentWeapon.gameObject : null);
        //FIX
        activeCloneMachine.StoreClone(new List<RecordedCommand>(commands), recordingStartPos);
        //

        commands.Clear();
        activeCloneMachine = null;
        recordingIcon.SetActive(false);
        timeCloneController.RemoveAllActiveClones();
        ResetAllObjects();
        PhysicsObject.ResetAllPhysics(true);
        GetComponent<PlayerStatus>().DestroyAllProjectiles();
        if(enemyManager)
        {
            enemyManager.ResetEnemies();
            enemyManager.ResetCurrentBoss();
        }
        if(aim.CurrentWeapon != null) aim.DropWeapon();
        WeaponManager.ResetAllWeapons();
        if(startingWeapon != null) aim.PickUpWeapon(startingWeapon);
    }

    public void ResetAllObjects()
    {
        ResetObjects(events);
    }

    void ResetObjects(GameObject parent)
    {
        for(int i = 0; i < parent.transform.childCount; i++)
        {
            GameObject child = parent.transform.GetChild(i).gameObject;
            if(child.tag == "Button")
            {
                Button b = child.GetComponent<Button>();
                b.ResetAttachedEvents();
            }
            else if(child.tag == "Target")
            {
                Target t = child.GetComponent<Target>();
                t.ResetTarget();
            }
            else if(child.transform.childCount > 0 && child.GetComponents<Component>().Length == 1)
            {
                ResetObjects(child);
            }
        }
    }

    public void AddCommand(Vector2 movement, bool jumping, float angle, bool shooting, float raySwitchValue, GameObject newWeapon = null)
    {
        accumulatedTime += Time.fixedDeltaTime;
        RecordedCommand command = new RecordedCommand(movement, jumping, angle, shooting, accumulatedTime, raySwitchValue, newWeapon);
        commands.Add(command);
    }

    public void CancelRecording(bool playerDied = false)
    {
        if(recording)
        {
            recording = false;
            accumulatedTime = 0;
            commands.Clear();
            activeCloneMachine = null;
            recordingIcon.SetActive(false);
            timeCloneController.RemoveAllActiveClones();
            GetComponent<PlayerController>().RecordingCancelled();
            if(playerDied)
            {
                ResetAllObjects();
                PhysicsObject.ResetAllPhysics(true);
                GetComponent<PlayerStatus>().DestroyAllProjectiles();
                if(enemyManager)
                {
                    enemyManager.ResetEnemies();
                    enemyManager.ResetCurrentBoss();
                }
                if(aim.CurrentWeapon != null) aim.DropWeapon();
                WeaponManager.ResetAllWeapons();
                if(startingWeapon != null) aim.PickUpWeapon(startingWeapon);
            }
        }
    }

    void UpdateTimerText()
    {
        float minutes = Mathf.FloorToInt(timer / 60.0f);
        float seconds = Mathf.FloorToInt(timer % 60);
        timerText.text = string.Format("{0:0}:{1:00}", minutes, seconds);
    }
}
