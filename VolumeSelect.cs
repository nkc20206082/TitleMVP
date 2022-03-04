using UnityEngine;

public class VolumeSelect : MonoBehaviour
{
    [SerializeField] SoundMenuModel _SoundMenumodel;
    public void Select()
    {
        _SoundMenumodel.Selected();
        Debug.Log("Volume");
    }
}
