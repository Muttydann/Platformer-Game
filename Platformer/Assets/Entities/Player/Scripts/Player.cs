using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private PlayerActions act;
    [SerializeField] private PlayerComponents comp;
    private PlayerReferences refer;
    private PlayerStats stats;
    private PlayerUtilities util;

    public PlayerComponents Comp { get => comp; set => comp = value; }

    private void Awake()
    {
        act = new PlayerActions(this);
    }

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        act.Move(transform);
    }

}
