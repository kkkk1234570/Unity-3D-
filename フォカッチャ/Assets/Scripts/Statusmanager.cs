using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Statusmanager : MonoBehaviour
{
    protected enum State
    {
        Normal,
        Attack 
    }
    public bool IsMove => State.Normal == state;
    public bool IsAttack => State.Normal == state;
    protected Animator animator;
    protected State state = State.Normal;
    [SerializeField] private int Maxlife;
    [SerializeField] private int life;

    protected virtual void Start()
    {
        life = Maxlife;

        animator = GetComponentInChildren<Animator>();

    }

    public void GoToAttack()
    {
        if (!IsAttack) return;//Attack‚È‚çreturn

        state = State.Attack;
        animator.SetTrigger("Attack");
    }
    public void GoToNormal()
    {
        state = State.Normal;

    }
    public int Life()
    {
        return life;
    }
    


}