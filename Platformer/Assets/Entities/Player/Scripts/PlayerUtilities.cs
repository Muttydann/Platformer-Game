using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUtilities
{
    private Player player;

    public void HandleInput()
    {
        player.Stats.dir = new Vector2(Input.GetAxisRaw("Horizontal"), player.Comp.Rb.velocity.y);
    }

    public PlayerUtilities(Player player)
    {
        this.player = player;
    }

}
