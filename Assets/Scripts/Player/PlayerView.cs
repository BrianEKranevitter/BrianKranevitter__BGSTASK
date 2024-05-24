using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    public Animator anim;
    public SpriteRenderer[] head, torso, legs;
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
}