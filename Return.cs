using UnityEngine;

public class Return : MonoBehaviour
{
    [SerializeField] OptionModel _optionModel;
    public void Select()
    {
        _optionModel.Escape();
        Debug.Log("Option");
    }
}
