using System.Collections;
using System.Collections.Generic;
using Fusion;
using UnityEngine;

public class bullet : NetworkBehaviour
{
    [Networked]
    private TickTimer life { get; set; }

    [SerializeField]
    private float bulletSpeed = 5f;

    public override void Spawned()
    {
        life = TickTimer.CreateFromSeconds(Runner, 5.0f);
    }

    public override void FixedUpdateNetwork()
    {
        if (life.Expired(Runner))
        {
            Runner.Despawn(Object);
        }
        else
        {
            transform.position += bulletSpeed * transform.forward * Runner.DeltaTime;
        }

    }
}
