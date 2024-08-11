using TMPro;
using UnityEngine;

public class TextQuest : MonoBehaviour
{
    #region Variables

    [SerializeField] private TMP_Text _descriptionLabel;
    [SerializeField] private TMP_Text _answerLabel;
    [SerializeField] private TMP_Text _locationLabel;
    [SerializeField] private Step _startStep;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        _locationLabel.text = _startStep.Location;
        _descriptionLabel.text = _startStep.Description;
        _answerLabel.text = _startStep.Answer;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _locationLabel.text = "Дом";
            _descriptionLabel.text = "GAME OVER! Приключения тебя ждали, а ты не пошел ТТ.";
            _answerLabel.text = string.Empty;
        }
    }

    #endregion
}