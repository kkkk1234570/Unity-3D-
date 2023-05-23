using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackScript : MonoBehaviour
{
    public float attackspan = 0.5f;
    public Collider attackCollider;

    private Statusmanager status;

    // Start is called before the first frame update
    private void Start()
    {
        status = GetComponent<Statusmanager>();
    }
    public void CheckAttack()
    {
        if (!status.IsAttack) return;

        status.GoToAttack();
    }


    public void AttackStart()
    {
        attackCollider.enabled = true;
    }

    public void AttackEnd()
    {
        attackCollider.enabled = false;
        StartCoroutine(Attackspan());
    }
    private IEnumerator Attackspan()
    {
        yield return new WaitForSeconds(attackspan);
        status.GoToNormal();
    }

}