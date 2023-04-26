using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TrapType
{
    Trigger,Timer
}

public abstract class Trap : MonoBehaviour
{
    [SerializeField] private List<float> activateOnTime;
    [SerializeField] private List<bool> activatedYet;
    public GameObject trigger;
    private TrapType type;
    private bool active;

    void Start() 
    {
        activatedYet = new List<bool>();
        for (int i = 0; i < activateOnTime.Count; i++)
        {
            activatedYet.Add(false);
        }
    }
    void Update()
    {
        if (type == TrapType.Trigger && trigger.GetComponent<Trigger>().triggered) active = true;
        else if (type == TrapType.Timer) active = true;

        if (active)
        {
            for (int i = 0; i < activateOnTime.Count; i++)
            {
                if (activatedYet[i]) continue;

                if (activateOnTime[i] > GameManager.Instance.time)
                {
                    Activate();
                    activatedYet[i] = true;
                }
            }
        }
    }


    public abstract void Activate();
}