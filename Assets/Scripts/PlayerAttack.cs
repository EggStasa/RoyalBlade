using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] public GameObject[] canAttacks;
    [SerializeField] private GameObject pivotWeapon;
    [SerializeField] private bool left = false;

    private List<ICanAttack> _canAttack = new List<ICanAttack>();

    public void Start()
    {
        foreach (var item in canAttacks)
        {
            if (item.TryGetComponent(out ICanAttack attack))
               _canAttack.Add(attack);
        }

        left = true;
    }

    public void AttackButton()
    {
        StartCoroutine(RotateWeapon());
    }


    private IEnumerator RotateWeapon()
    {
        left = !left;

        Vector3 needRotate;
        int back = 0;

        if (left)
        {
            back = -20;
            needRotate = new Vector3(0f, 0f, 0f);
        }
        else
        {
            back = 20;
            needRotate = new Vector3(0f, 0f, 180f);
        }


        for (int i = 0; i < 9; i++)
        {
            pivotWeapon.transform.Rotate(Vector3.forward * back);
            yield return new WaitForFixedUpdate();
        }

        pivotWeapon.transform.rotation = Quaternion.Euler(needRotate);

        yield return new WaitForEndOfFrame();
    }
}
