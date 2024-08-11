using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TextQuest : MonoBehaviour
{
    #region Variables

    [SerializeField] private TMP_Text _descriptionLabel;
    [SerializeField] private TMP_Text _answerLabel;
    [SerializeField] private TMP_Text _locationLabel;
    [SerializeField] private Step _startStep;

    private Step _currentStep;
    

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        SetCurrentStepAndUpdateUi(_startStep);
    }

    private void SetCurrentStepAndUpdateUi(Step step)
    {
        _currentStep = step;
        UpdateUI();
    }

    private void Update()
    {
        for (int i = 1; i <= 9; i++)
        {
            if (Input.GetKeyDown(i.ToString()))
            {
                TryToNextStep(i);
            }
            
            else if (Input.GetKeyDown(KeyCode.Space)) 
            {
            _locationLabel.text = "Дом";
            _descriptionLabel.text = "GAME OVER! Приключения тебя ждали, а ты не пошел ТТ";
            _answerLabel.text = string.Empty; 
            }
        }
    }

    private void TryToNextStep(int number)
    {
        int nextStepsCount = _currentStep.NextSteps.Length;
        if (number > nextStepsCount)
        {
            return;
        }
        int nextStepIndex = number - 1;
        Step nextSteps = _currentStep.NextSteps[nextStepIndex];
        SetCurrentStepAndUpdateUi(nextSteps);
    }

    private void UpdateUI()
    {
        _descriptionLabel.text = _currentStep.Description;
        _answerLabel.text = _currentStep.Answer;
        _locationLabel.text = _currentStep.Location;
    }

    #endregion
}