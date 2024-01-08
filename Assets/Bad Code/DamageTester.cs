using UnityEngine;

public class DamageTester : MonoBehaviour
{
    public AttributesManager playerAtm;
    public AttributesManager enemyAtm;

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F11))
        {
            playerAtm.DealDamage(enemyAtm.gameObject);
        }

    }

}
