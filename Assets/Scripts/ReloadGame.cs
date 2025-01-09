using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadGame : MonoBehaviour
{
    public void ReloadScene(int i)
    {
        SceneManager.LoadScene(i);
    }
}
