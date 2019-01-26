using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField] private float timer;
    [SerializeField] private CharacterMovement player;
    [SerializeField] private HomeBehavior home;
    [SerializeField] private float sceneTransitionDelay;
   


	// Use this for initialization
	void Start ()
	{
	    player.PlayerKilled += GameOver;
        home.VictoryTriggered += Victory;

	}

    void Victory()
    {
        LoadNextSceneDelayed(sceneTransitionDelay, "VictoryScene");
    }

    void GameOver()
    {
        //Play some animation or something, therefore allow a delay
        LoadNextSceneDelayed(sceneTransitionDelay, "EndScene" );

    }

    IEnumerator LoadNextSceneDelayed(float time, String sceneName)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(sceneName);

    }

    void OnDisable()
    {
        player.PlayerKilled -= GameOver;
    }
}
