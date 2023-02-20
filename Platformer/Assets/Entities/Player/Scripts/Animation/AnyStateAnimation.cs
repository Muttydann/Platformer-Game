using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RIG { BODY, LEGS};

public class AnyStateAnimation : MonoBehaviour
{

    public RIG AnimRig { get; set; }

    public string Nm { get; set; }

    public bool Active { get; set; }


    public AnyStateAnimation(RIG rig, string nm)
    {
        AnimRig = rig;
        Nm = nm;
    }
}
