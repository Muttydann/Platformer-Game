using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnyStateAnimator : MonoBehaviour
{

    private Animator animat;
    private Dictionary<string, AnyStateAnimation> anims = new Dictionary<string, AnyStateAnimation>();

    private string curAnimL = string.Empty;
    private string curAnimB = string.Empty;

    public void Awake()
    {
        animat = GetComponent<Animator>();
    }

    public void AddAnim(params AnyStateAnimation[] newAnims)
    {
        for(int i = 0; i < newAnims.Length; i++)
        {
            anims.Add(newAnims[i].Nm, newAnims[i]);
        }
    }


    public void TryPlayAnim(string newAnim)
    {
        switch (anims[newAnim].AnimRig)
        {
            case RIG.BODY: PlayAnim(ref curAnimB);
                break;
            case RIG.LEGS: PlayAnim(ref curAnimL);
                break;
        }

        void PlayAnim(ref string curAnim)
        {
            if(curAnim == "")
            {
                anims[newAnim].Active = true;
                curAnim = newAnim;
            }else if(curAnim != newAnim)
            {
                anims[curAnim].Active = false;
                anims[newAnim].Active = true;
                curAnim = newAnim;
            }
        }
        Animate();
    }

    private void Animate()
    {
        foreach(string key in anims.Keys)
        {
            animat.SetBool(key, anims[key].Active);
        }
    }

}
