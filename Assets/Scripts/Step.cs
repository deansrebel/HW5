using UnityEngine;

public class Step : MonoBehaviour
{
    #region Variables

    [TextArea(5,10)]
    [SerializeField] private string _description;
    [TextArea(5,10)]
    [SerializeField] private string _answers;
    [SerializeField] private string _location;
    
    [SerializeField] private Step[] _nextSteps;
    
    [SerializeField] private Sprite []_background;
    [SerializeField] private  Sprite _newSprite;
    

    #endregion

    #region Properties
    
    public string Answer => _answers;
    public string Description => _description;
    public string Location => _location;
    public Step[] NextSteps => _nextSteps;

    #endregion
}