using UnityEngine;

public class OptionReturn : MonoBehaviour
{
    [SerializeField]private OptionModel _optionModel;
    public void Select()
    {
        _optionModel.Escape();
        Debug.Log("Option");
    }
}
