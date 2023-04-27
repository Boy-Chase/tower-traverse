using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Plate : MonoBehaviour
{
    public GameObject Shooter;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Shooter.GetComponent<ITrap>().Activate();
        }
    }
}
