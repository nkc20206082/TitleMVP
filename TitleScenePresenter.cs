using UnityEngine;

public class TitleScenePresenter : MonoBehaviour
{
    //============Model==============
    [SerializeField] TitleSceneModel _TitleSceneModel; 
    [SerializeField] OptionModel _OptionModel;
    [SerializeField] BGMModel _BGMModel;
    [SerializeField] SEModel _SEModel;

    //============View===============
    [SerializeField] TitleSceneView _TitleSceneView; 
    [SerializeField] OptionView _OptionView; 
    [SerializeField] BGMView _BGMView; 
    [SerializeField] SEView _SEView; 

    public void Start()
    {
        //ViewÇ…èâä˙ílÇëóÇÈ
        _TitleSceneView.SelectIcon(_TitleSceneModel.selectnum);
        _OptionView.SelectIcon(_OptionModel.selectnum);
        _BGMView.Volume(_BGMModel.BGMvolume);
        _SEView.Volume(_SEModel.SEvolume);

        //===========TiltleScene Event==============
        _TitleSceneModel.SelectEvent += _TitleSceneView.SelectIcon;

        //===========OptionScene Event=============
        _OptionModel.OptionSelected += _OptionView.OptionMenuActive;
        _OptionModel.SelectEvent += _OptionView.SelectIcon;

        //===========BGM Event==================
        _BGMModel.VolumeUp += _BGMView.Volume;
        _BGMModel.VolumeDown += _BGMView.Volume;

        //============SE Event==================
        _SEModel.VolumeUp += _SEView.Volume;
        _SEModel.VolumeDown += _SEView.Volume;
    }

}
