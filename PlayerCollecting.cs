using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollecting : MonoBehaviour
{
    public bool PickedKey;
    public bool inRange;

    //Boss Level
    public bool BossPickedKey = true;
    public bool BossinRange;
    public bool BossinRange2;
    public bool BossinRange3;
    public bool SwitchPulled1;
    public bool SwitchPulled2;
    public bool SwitchPulled3;
    public AudioSource source;
    public AudioClip AudioClip;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inRange)
        {
            if (PickedKey)
            {
                Debug.Log("You fixed it!");
                PlayGame();
            }

            if (!PickedKey)
            {
                Debug.Log("Find the repair kit!");
            }
        }

        //Boss level
        if (Input.GetKeyDown(KeyCode.E) && BossinRange)
        {
            if (BossPickedKey)
            {
                Debug.Log("You pulled a lever!");
                SwitchPulled1 = true;
                Audio();
            }
        }

        if (Input.GetKeyDown(KeyCode.E) && BossinRange2)
        {
            if (BossPickedKey)
            {
                Debug.Log("You pulled a lever! (2)");
                SwitchPulled2 = true;
                Audio();
            }
        }

        if (Input.GetKeyDown(KeyCode.E) && BossinRange3)
        {
            if (BossPickedKey)
            {
                Debug.Log("You pulled a lever! (3)");
                SwitchPulled3 = true;
                Audio();
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Key"))
        {
            PickedKey = true;
        }

        if (collision.gameObject.CompareTag("Meterkast"))
        {
            inRange = true;
        }

        //Boss level
        if (collision.gameObject.CompareTag("BossKast1"))
        {
            BossinRange = true;
        }

        if (collision.gameObject.CompareTag("BossKast2"))
        {
            BossinRange2 = true;
        }

        if (collision.gameObject.CompareTag("BossKast3"))
        {
            BossinRange3 = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Meterkast"))
        {
            inRange = false;
        }

        //Boss level
        if (collision.gameObject.CompareTag("BossKast1"))
        {
            BossinRange = false;
        }

        if (collision.gameObject.CompareTag("BossKast2"))
        {
            BossinRange2 = false;
        }

        if (collision.gameObject.CompareTag("BossKast3"))
        {
            BossinRange3 = false;
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Audio()
    {
        source.clip = AudioClip;
        source.Play();
    }
}
