using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private PlayerActions act;
    [SerializeField] private PlayerComponents comp;
    private PlayerReferences refer;
    [SerializeField] private PlayerStats stats;
    private PlayerUtilities util;

    public PlayerComponents Comp { get => comp; set => comp = value; }
    public PlayerStats Stats { get => stats; set => stats = value; }

    private void Start()
    {
        act = new PlayerActions(this);
        util = new PlayerUtilities(this);
        stats.spd = stats.WalkSpd;

        AnyStateAnimation[] anims = new AnyStateAnimation[]
        {
            new AnyStateAnimation(RIG.BODY, "b_Idle"),
            new AnyStateAnimation(RIG.BODY, "b_Walk"),
            new AnyStateAnimation(RIG.LEGS, "l_Idle"),
            new AnyStateAnimation(RIG.LEGS, "l_Walk")
        };

        comp.Animat.AddAnim(anims);
    }


    void Update()
    {
        util.HandleInput();
    }

    private void FixedUpdate()
    {

        act.Move(transform);

    }

}
