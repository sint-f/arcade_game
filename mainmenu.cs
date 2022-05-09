using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public Button Play;
    void Start()
    {
        Button Playbtn = Play.GetComponent<Button>();
        Play.onClick.AddListener(PlayGame);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("quit");
        }
    }

    void Awake()
    {
        Play.Select();
    }
    public Animator transition;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
