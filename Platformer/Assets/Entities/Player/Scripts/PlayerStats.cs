using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerStats
{
    public Vector2 dir { get; set; }
    public float spd { get; set; }
    public float WalkSpd { get => walkSpd; set => walkSpd = value; }
    public float RunSpd { get => runSpd; set => runSpd = value; }
    public bool jump { get; set; }
    public bool grounded { get; set; }

    [SerializeField] private float walkSpd;
    [SerializeField] private float runSpd;


}
