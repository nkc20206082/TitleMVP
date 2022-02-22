using UnityEngine;

public class TitleScenePresenter : MonoBehaviour
{
    //============Model==============
    [SerializeField] TitleSceneModel _TitleSceneModel; 
    [SerializeField] OptionModel _OptionModel;
    [SerializeField] BGMModel _BGMModel;

    //============View===============
    [SerializeField] TitleSceneView _TitleSceneView; 
    [SerializeField] OptionView _OptionView; 
    [SerializeField] BGMView _BGMView; 

    public void Start()
    {
        _TitleSceneView.SelectIcon(_TitleSceneModel.selectnum);
        _OptionView.SelectIcon(_OptionModel.selectnum);
        _BGMView.Volume(_BGMModel.BGMvolume);

        _TitleSceneModel.SelectEvent += _TitleSceneView.SelectIcon;

        _OptionModel.OptionSelected += _OptionView.OptionMenuActive;

        _OptionModel.SelectEvent += _OptionView.SelectIcon;

        _BGMModel.VolumeUp += _BGMView.Volume;
        _BGMModel.VolumeDown += _BGMView.Volume;
    }

}
