using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellBook : MonoBehaviour
{
    public Animator animator;

    public void OpenSpellBook()
    {
        if (!animator.GetBool("isOpenSpellBook"))
        {
            animator.SetBool("isOpenSpellBook", true);
            animator.SetBool("isCloseSpellBook", false);
        }
        else if (animator.GetBool("isOpenSpellBook")) 
        {
            animator.SetBool("isOpenSpellBook", false);
            animator.SetBool("isCloseSpellBook", true);
        }
    } 
}
