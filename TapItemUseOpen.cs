using UnityEngine;

public class TapItemUseOpen : TapCollider
{
    public GameObject ItemImage;
    public GameObject[] ActiveObjects;
    public string OpenPositionName;
    public GameObject OpenCollider;

    private bool _IsOpen = false; // 実行済みフラグ

    protected override void OnTap()
    {
        base.OnTap();

        // `OnTap` では開閉フラグを切り替える
        if (ItemImage.activeSelf)
        {
            // ItemImage.SetActive(false);
            foreach (var obj in ActiveObjects)
            {
                obj.SetActive(true);
            }

            _IsOpen = true; // 実行済みとして設定
        }
    }

    private void Update()
    {
        // Update で `_IsOpen` を判別し、カメラ移動とコライダー設定を実行
        if (_IsOpen)
        {
            _IsOpen = false; // フラグをリセット
            CameraMove();    // カメラ移動とコライダー設定
        }
    }

    private void CameraMove()
    {
        CameraManager.Instance.ChangeCameraPosition(OpenPositionName);
        OpenCollider.SetActive(true);
    }
}
