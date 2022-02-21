using UnityEngine;

public class TitleScenePresenter : MonoBehaviour
{
    [SerializeField] TitleSceneModel _TitleSceneModel; 
    [SerializeField] OptionModel _OptionModel; 
    [SerializeField] TitleSceneView _TitleSceneView; 
    [SerializeField] OptionView _OptionView; 

    public void Start()
    {
        _TitleSceneView.SelectIcon(_TitleSceneModel.selectnum);

        _TitleSceneModel.SelectEvent += _TitleSceneView.SelectIcon;

        _OptionModel.OptionSelected += _OptionView.OptionMenuActive;
    }

}
