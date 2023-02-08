using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions
{
    private Player player;

    public void Move(Transform trans)
    {
        player.Comp.Rb.velocity = new Vector2(player.Stats.dir.x * player.Stats.spd * Time.deltaTime, player.Stats.dir.y);
    }

    public PlayerActions(Player player)
    {
        this.player = player;
    }
}
