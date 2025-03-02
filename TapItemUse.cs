using UnityEngine;

public class TapItemUse : TapCollider
{
    public GameObject ItemImage;
    public GameObject[] ActiveObjects;
    public GameObject[] InactiveObjects; // 追加: 非アクティブにするオブジェクト

    protected override void OnTap()
    {
        base.OnTap();

        if (ItemImage.activeSelf)
        {
            gameObject.SetActive(false);

            // 有効化するオブジェクト
            foreach (var obj in ActiveObjects)
            {
                obj.SetActive(true);
            }

            // 無効化するオブジェクト
            foreach (var obj in InactiveObjects)
            {
                obj.SetActive(false);
            }
        }
    }
}
