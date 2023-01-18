using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    [SerializeField]
    private GameObject canvasStart;
    [SerializeField]
    private GameObject canvasGame;
    [SerializeField]
    private Text title;
    [SerializeField]
    private Text tutorial;
    [SerializeField]
    private Text credit;
    [SerializeField]
    private Text button;

    void Start()
    {
        title.text = Texts.msgGameTitle;
        tutorial.text = Texts.msgGameTutorial;
        button.text = Texts.msgGameButton;
        credit.text = Texts.msgGameCredit;
        Time.timeScale = 0;
    }

    public void PlayGame()
    {
        canvasStart.SetActive(false);
        canvasGame.SetActive(true);
        Time.timeScale = 1;
    }
}
