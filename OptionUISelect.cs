using UnityEngine;

public class OptionUISelect : MonoBehaviour
{
    [SerializeField] private OptionModel _OptionModel;
    public void Select()
    {
        _OptionModel.Selected();
        Debug.Log("Option");
    }
}
