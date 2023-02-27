using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions
{
    private Player player;

    public void Move(Transform trans)
    {
        player.Comp.Rb.velocity = new Vector2(player.Stats.dir.x * player.Stats.spd * Time.deltaTime, player.Stats.dir.y);
        if(player.Stats.jump == true)
        {
            player.Comp.Rb.AddForce(Vector2.up * 300);
            player.Stats.jump = false;
            player.Stats.grounded = false;
        }


        if(player.Stats.dir.x != 0)
        {
            trans.localScale = new Vector3(player.Stats.dir.x < 0 ? -1 : 1, 1, 1);
            player.Comp.Animat.TryPlayAnim("b_Walk");
            player.Comp.Animat.TryPlayAnim("l_Walk");
        }else if(player.Comp.Rb.velocity == Vector2.zero)
        {
            player.Comp.Animat.TryPlayAnim("b_Idle");
            player.Comp.Animat.TryPlayAnim("l_Idle");
        }
    }

    public PlayerActions(Player player)
    {
        this.player = player;
    }
}
