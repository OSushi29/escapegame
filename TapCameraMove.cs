using UnityEngine;

public class TapCameraMove : TapCollider
{
    public string MovePositionName;
    
    protected override void OnTap()
    {
        base.OnTap();

        CameraManager.Instance.ChangeCameraPosition(MovePositionName);
    }
}
