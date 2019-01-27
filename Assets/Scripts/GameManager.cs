using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField] private PlayerHealth _player;
    [SerializeField] private HomeBehavior _home;
    [SerializeField] private float _sceneTransitionDelay = 1f;
    private DayNightController _dayNightController;
    


	// Use this for initialization
	void Start ()
	{
        _dayNightController = this.GetComponent<DayNightController>();
	    _player.PlayerKilled += GameOver;
	    _dayNightController.TimeOut += GameOver;
     //   _home.VictoryTriggered += Victory;

	}

    void Victory()
    {
        StartCoroutine(LoadNextSceneDelayed(_sceneTransitionDelay, 3));
    }

    void GameOver()
    {
        //Play some animation or something, therefore allow a delay
        StartCoroutine(LoadNextSceneDelayed(_sceneTransitionDelay, 3));


    }

    IEnumerator LoadNextSceneDelayed(float time, int sceneNumber)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(sceneNumber);
    }

    void OnDisable()
    {
        _player.PlayerKilled -= GameOver;
        _dayNightController.TimeOut -= GameOver;
      //  _home.VictoryTriggered -= Victory;
    }
}
