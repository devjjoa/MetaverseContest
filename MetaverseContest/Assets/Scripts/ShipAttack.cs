using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipAttack : MonoBehaviour
{
    public GameObject attackEffect;

    public GameObject textEnemyDown;
    public GameObject[] leeAttackPopup;


    private int leeAttacknum;
    private bool isLeePopup = true;



    private float popupTime = 0;
    private void OnTriggerEnter(Collider col)
    {
        StartCoroutine(EnemyDown(col));
    }


    IEnumerator EnemyDown(Collider col)
    {
        if (col.CompareTag("ENEMY"))
        {
            print(col.transform.name + " Àû°ú ºÎµ÷Çû´Ù");
            BoatAlignNormal boat = col.transform.GetComponent<BoatAlignNormal>();
            if (boat)
            {

                attackEffect.SetActive(true);
                textEnemyDown.SetActive(true);
                yield return new WaitForSeconds(2.0f);
                boat._bottomH = 100f;
                attackEffect.SetActive(false);
                textEnemyDown.SetActive(false);
                if (isLeePopup == false) isLeePopup = true;
   

                    int ran = Random.Range(0, leeAttackPopup.Length);
                    for (int i = 0; i < leeAttackPopup.Length; i++)
                    {
                         leeAttackPopup[i].SetActive(i==ran);
                    }

                    yield return new WaitForSeconds(5.0f);
                    leeAttackPopup[ran].SetActive(false);                
            }
        }        
    }
}
