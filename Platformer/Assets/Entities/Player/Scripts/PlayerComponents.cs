using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerComponents
{
    [SerializeField] private Rigidbody2D rb;

    public Rigidbody2D Rb { get => rb; set => rb = value; }
}
