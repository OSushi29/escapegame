using UnityEngine;

public class BoxDoorDisappear : MonoBehaviour
{
    public string OpenPositionName;
    private bool hasDisappeared = false;

    void Update()
    {
        if (!hasDisappeared && OpenPositionName == CameraManager.Instance.CurrentPositionName)
        {
            gameObject.SetActive(false);
            hasDisappeared = true; // 一度消えたらフラグを立てる
        }
    }
}
