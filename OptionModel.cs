using UnityEngine;
using System;

public class OptionModel : MonoBehaviour
{

    public event Action<bool> OptionSelected;

    public void Selected()
    {
        OptionSelected(true);
    }

    public void EscapeOption()
    {
        OptionSelected(false);
    }
}
