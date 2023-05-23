using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : Statusmanager
{
    private PlayerMove pm;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        pm = GetComponent<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("MoveSpeed", pm.direction.magnitude);
    }

    public void Jump()
    {
        animator.SetBool("Jump", true);
    }

}