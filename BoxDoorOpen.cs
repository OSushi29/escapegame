using UnityEngine;

public class BoxDoorOpen : MonoBehaviour
{
    public string OpenPositionName;

    public Vector3 OpenRotate;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(OpenPositionName == CameraManager.Instance.CurrentPositionName)
            gameObject.transform.localRotation = Quaternion.Euler(OpenRotate);
        else gameObject.transform.localRotation = Quaternion.identity;
    }
}

