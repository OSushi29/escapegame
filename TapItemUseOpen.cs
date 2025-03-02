using UnityEngine;

public class TapItemUseOpen : TapCollider
{
    public GameObject ItemImage;
    public GameObject[] ActiveObjects;
    public string OpenPositionName;
    public GameObject OpenCollider;

    private bool _IsOpen = false; // ���s�ς݃t���O

    protected override void OnTap()
    {
        base.OnTap();

        // `OnTap` �ł͊J�t���O��؂�ւ���
        if (ItemImage.activeSelf)
        {
            // ItemImage.SetActive(false);
            foreach (var obj in ActiveObjects)
            {
                obj.SetActive(true);
            }

            _IsOpen = true; // ���s�ς݂Ƃ��Đݒ�
        }
    }

    private void Update()
    {
        // Update �� `_IsOpen` �𔻕ʂ��A�J�����ړ��ƃR���C�_�[�ݒ�����s
        if (_IsOpen)
        {
            _IsOpen = false; // �t���O�����Z�b�g
            CameraMove();    // �J�����ړ��ƃR���C�_�[�ݒ�
        }
    }

    private void CameraMove()
    {
        CameraManager.Instance.ChangeCameraPosition(OpenPositionName);
        OpenCollider.SetActive(true);
    }
}
