using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeTravelButton : MonoBehaviour
{
    public Button timeTravelButton;

    void Start()
    {
       
        timeTravelButton.gameObject.SetActive(false);
    }

    public void ShowButton()
    {
      
        timeTravelButton.gameObject.SetActive(true);
    }

    public void OnButtonClick()
    {
        
        SceneManager.LoadScene("FightScene");
    }
}
