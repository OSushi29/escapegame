using UnityEngine;

public class TapItemUse : TapCollider
{
    public GameObject ItemImage;
    public GameObject[] ActiveObjects;
    public GameObject[] InactiveObjects; // �ǉ�: ��A�N�e�B�u�ɂ���I�u�W�F�N�g

    protected override void OnTap()
    {
        base.OnTap();

        if (ItemImage.activeSelf)
        {
            gameObject.SetActive(false);

            // �L��������I�u�W�F�N�g
            foreach (var obj in ActiveObjects)
            {
                obj.SetActive(true);
            }

            // ����������I�u�W�F�N�g
            foreach (var obj in InactiveObjects)
            {
                obj.SetActive(false);
            }
        }
    }
}
