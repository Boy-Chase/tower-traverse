using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TrapType
{
    Trigger,Timer
}

public abstract class Trap : MonoBehaviour
{
    public float activateOnTime;
    public GameObject trigger;

    void Start()
    {
        //TODO: hookup trap to trigger's game object
    }

    void Update()
    {
        //TODO: Implement activating on gamemanager time
    }
    public abstract void Activate();
}
