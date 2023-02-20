using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerComponents
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private AnyStateAnimator animat;

    public Rigidbody2D Rb { get => rb; set => rb = value; }
    public AnyStateAnimator Animat { get => animat; set => animat = value; }
}
