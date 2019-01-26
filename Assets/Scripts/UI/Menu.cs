using UnityEngine;
using UnityEngine.SceneManagement;
using Button = UnityEngine.UI.Button;

public class Menu : MonoBehaviour
{

    [SerializeField] private Button _startButton;
    [SerializeField] private Button _quitButton;
   

	// Use this for initialization
	void Start ()
	{
        _startButton.onClick.AddListener(OnStartBtnClicked);
        _quitButton.onClick.AddListener(OnQuitBtnClicked);
	}


    public void OnStartBtnClicked()
    {
        SceneManager.LoadScene(1);
    }

    public void OnQuitBtnClicked()
    {

        Application.Quit();
    }

}
