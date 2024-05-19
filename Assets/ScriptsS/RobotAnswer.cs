using UnityEngine;
using UnityEngine.UI;

public class RobotAnswer : MonoBehaviour
{
    public Text questionText;
    public Text answerText;
    public Animator robotAnimator;
    public TimeTravelButton timeTravelButton; 

    bool questionAsked = false;
    bool answered = false;
    bool annoyed = false;

    void Start()
    {
        answerText.text = "";
        AskQuestion();
    }

    void AskQuestion()
    {
        questionText.text = "Soru: 5 + 3 kaç eder?";
        questionAsked = true;
    }

    void Update()
    {
        if (questionAsked && !answered)
        {
            robotAnimator.Play("SittingIdle");
            Invoke("GiveAnswer", 5.0f);
        }

        if (answered && !annoyed)
        {
            Invoke("Annoyed", 7.0f);
        }
    }

    void GiveAnswer()
    {
        if (questionAsked && !answered)
        {
            robotAnimator.Play("HandUpIdle");
            answerText.text = "Robot: 8";
            questionText.text = "";
            answered = true;

            
            Invoke("ShowTimeTravelButton", 5.0f);
        }
    }

    void ShowTimeTravelButton()
    {
        timeTravelButton.ShowButton();
    }

    void Annoyed()
    {
        robotAnimator.Play("RemyAnnoyed");
        annoyed = true;
    }

    void ResetQuestion()
    {
        questionText.text = "";
        answerText.text = "";
        questionAsked = false;
        answered = false;
        annoyed = false;
        AskQuestion();
    }
}
