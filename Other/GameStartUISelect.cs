using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartUISelect : MonoBehaviour
{
    public void Select()
    {
        Debug.Log("Start");
        SceneManager.LoadScene(0/*ÉVÅ[Éìñº*/);
    }
}
