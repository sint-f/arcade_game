using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bossscript : MonoBehaviour
{
    public PlayerCollecting PC;

    public GameObject Boss;

    public bool BossKilled;

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            if (PC.SwitchPulled1 && PC.SwitchPulled2 && PC.SwitchPulled3)
            {
                Destroy(Boss);
                BossKilled = true;
                Debug.Log("You Killed The Boss!!");
                SceneManager.LoadScene(0);
            }
            else if (!PC.SwitchPulled1)
            {
                Debug.Log("Find the switch!");
            }
            else if (!PC.SwitchPulled2)
            {
                Debug.Log("Find the switch! (2)");
            }
            else if (!PC.SwitchPulled3)
            {
                Debug.Log("Find the switch! (3)");
            }
            else
            {
                Debug.Log("Find and flip the switches!");
            }
        }
    }
}
