using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureShooter : MonoBehaviour, ITrap
{
    public GameObject arrow;

    public void Activate()
    {
        Instantiate(arrow);
        arrow.transform.position = gameObject.transform.position;
    }
}