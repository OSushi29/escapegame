using UnityEngine;
using UnityEngine.SceneManagement;

public class NewScript : MonoBehaviour
{
    public void LoadMainScene()
    {
        ES3.DeleteFile("SaveFile.es3");
        SceneManager.LoadScene("Main");
    }

}
