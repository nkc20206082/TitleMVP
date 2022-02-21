using UnityEngine;
using UnityEngine.UI;

public class OptionView : MonoBehaviour
{
    [SerializeField] Image _OptionImgs;

    public void OptionMenuActive(bool isOpen)
    {
        _OptionImgs.gameObject.SetActive(isOpen);
    }

}
