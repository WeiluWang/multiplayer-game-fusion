using System.Collections;
using System.Collections.Generic;
using Fusion;
using UnityEngine;

public enum InputButtons
{
    JUMP,
    FIRE
}
public struct NetworkInputData : INetworkInput
{
    public NetworkButtons buttons;
    public Vector3 movementInput;
}
