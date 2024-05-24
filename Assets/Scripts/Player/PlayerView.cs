using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    public Animator anim;
    bool flipped;

    public void FlipPlayerView(int orientation)
    {
        if (orientation == -1 && !flipped)
        {
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
            flipped = true;
        }
        else if (orientation == 1 && flipped)
        {
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
            flipped = false;
        }
    }

    public void MoveAnimation()
    {
        anim.SetBool("Moving", true);
    }

    public void IdleAnimation()
    {
        anim.SetBool("Moving", false);
    }
}