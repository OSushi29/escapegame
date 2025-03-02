using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnTap : MonoBehaviour
{
    public string sceneName = "NextScene"; // 切り替えたいシーンの名前

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // タップ（クリック）を検出
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) // レイキャストでオブジェクトを検出
            {
                if (hit.collider.gameObject == gameObject) // このオブジェクトがタップされたか判定
                {
                    SceneManager.LoadScene(sceneName); // シーンを切り替える
                    Debug.Log("hoge");
                }
            }
        }
    }
}
