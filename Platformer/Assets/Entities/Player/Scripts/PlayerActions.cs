using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions
{
    private Player player;

    public void Move(Transform trans)
    {
        player.Comp.Rb.velocity = Vector2.right;
    }

    public PlayerActions(Player player)
    {
        this.player = player;
    }
}
