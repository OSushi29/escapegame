using UnityEngine;
using UnityEngine.EventSystems;

public class TapCollider : MonoBehaviour
{

    public string EnableCameraPositionName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var CurrentTrigger = gameObject.AddComponent<EventTrigger>();

        var EntryClick = new EventTrigger.Entry();
        EntryClick.eventID = EventTriggerType.PointerClick;
        EntryClick.callback.AddListener((x) => OnTap());

        CurrentTrigger.triggers.Add(EntryClick);
    }

    // Update is called once per frame
    void Update()
    {
        if(EnableCameraPositionName == CameraManager.Instance.CurrentPositionName)
            GetComponent<BoxCollider>().enabled = true;
        else GetComponent<BoxCollider>().enabled = false;
    }

    protected virtual void OnTap()
    {

    }
}
