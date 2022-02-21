using UnityEngine;

public class Option : MonoBehaviour
{
    [SerializeField] OptionModel _optionModel;
    public void Select()
    {
        _optionModel.Selected();
        Debug.Log("Option");
    }
}
