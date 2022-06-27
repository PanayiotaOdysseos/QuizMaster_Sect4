using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float timerValue;
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;

    public bool loadNextQuestion;
    public bool isAnsweringQuestion;
    public float fillFraction;

    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if (isAnsweringQuestion)
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeToCompleteQuestion; // 5/10 = 0.5

            }
            else
            {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
                
            }

        }
        else
        {
            if (timerValue > 0 )
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;

            }
            else
            {
                isAnsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
                loadNextQuestion = true;

            }

        }
      
        /*  if (timerValue <=0 && isAnsweringQuestion == false)
        {
            timerValue = timeToCompleteQuestion;
            isAnsweringQuestion = true;
        }
        else if (timerValue <= 0 && isAnsweringQuestion == true)
        {
            timerValue = timeToShowCorrectAnswer;
            isAnsweringQuestion = false;

        } */

       // Debug.Log(isAnsweringQuestion + ": " + timerValue + "= " + fillFraction);
    }
}
