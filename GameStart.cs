using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public void Select()
    {
        Debug.Log("Start");
        SceneManager.LoadScene(0);
    }
}
