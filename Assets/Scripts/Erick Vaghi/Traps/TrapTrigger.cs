using System;
using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    [SerializeField] private DeathTimer deathTimer;

    private void Start()
    {
        deathTimer.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        deathTimer.enabled = true;
    }
}
