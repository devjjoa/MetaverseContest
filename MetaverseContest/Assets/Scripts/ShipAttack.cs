using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipAttack : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        StartCoroutine(EnemyDown(col));
    }


    IEnumerator EnemyDown(Collider col)
    {
        if (col.CompareTag("ENEMY"))
        {
            print(col.transform.name + " ���� �ε�����");
            BoatAlignNormal boat = col.transform.GetComponent<BoatAlignNormal>();
            if (boat)
            {
                yield return new WaitForSeconds(2.0f);
                boat._bottomH = 100f;
            }
        }        
    }
}
