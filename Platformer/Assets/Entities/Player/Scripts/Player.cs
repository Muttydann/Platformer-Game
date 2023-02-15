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

    private void Awake()
    {
        act = new PlayerActions(this);
        util = new PlayerUtilities(this);
        stats.spd = stats.WalkSpd;

    }

    void Start()
    {
        Comp.Anim.SetBool("l_Idle", true);
    }

   
    void Update()
    {
        util.HandleInput();
    }

    private void FixedUpdate()
    {

        act.Move(transform);
        if(Comp.Rb.velocity.magnitude > 0)
        {
            Comp.Anim.SetBool("l_Idle", false);
            Comp.Anim.SetBool("l_Walk", true);
        }
        else
        {
            Comp.Anim.SetBool("l_Idle", true);
            Comp.Anim.SetBool("l_Walk", false);
        }
    }

}
