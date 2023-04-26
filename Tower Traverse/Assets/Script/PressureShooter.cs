using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureShooter : MonoBehaviour
{
    public GameObject arrow;

    public void Fire()
    {
        Instantiate(arrow);
        arrow.transform.position = gameObject.transform.position;
    }
}
