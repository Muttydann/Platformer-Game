using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerComponents
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator anim;

    public Rigidbody2D Rb { get => rb; set => rb = value; }
    public Animator Anim { get => anim; set => anim = value; }
}
