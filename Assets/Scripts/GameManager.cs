using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField] private float _timer;
    [SerializeField] private CharacterMovement _player;
    [SerializeField] private HomeBehavior _home;
    [SerializeField] private float _sceneTransitionDelay;
   


	// Use this for initialization
	void Start ()
	{
	    _player.PlayerKilled += GameOver;
        _home.VictoryTriggered += Victory;

	}

    void Victory()
    {
        LoadNextSceneDelayed(_sceneTransitionDelay, 3);
    }

    void GameOver()
    {
        //Play some animation or something, therefore allow a delay
        LoadNextSceneDelayed(_sceneTransitionDelay, 4);

    }

    IEnumerator LoadNextSceneDelayed(float time, int sceneNumber)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(sceneNumber);

    }

    void OnDisable()
    {
        _player.PlayerKilled -= GameOver;
    }
}
