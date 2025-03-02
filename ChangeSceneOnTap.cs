using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnTap : MonoBehaviour
{
    public string sceneName = "NextScene"; // �؂�ւ������V�[���̖��O

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // �^�b�v�i�N���b�N�j�����o
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) // ���C�L���X�g�ŃI�u�W�F�N�g�����o
            {
                if (hit.collider.gameObject == gameObject) // ���̃I�u�W�F�N�g���^�b�v���ꂽ������
                {
                    SceneManager.LoadScene(sceneName); // �V�[����؂�ւ���
                    Debug.Log("hoge");
                }
            }
        }
    }
}
