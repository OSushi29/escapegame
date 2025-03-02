using UnityEngine;

public class OpenJudge : MonoBehaviour
{
    private bool _IsOpen = false;

    public TapObjectChange[] TapChanges;
    public int[] AnswerIndexes;
    public string OpenPositionName;
    public GameObject OpenCollider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_IsOpen)
            return;

        if (TapChanges.Length != AnswerIndexes.Length)
        {
            Debug.LogError("TapChanges‚ÆAnswerIndexes‚Ì’·‚³‚ªˆê’v‚µ‚Ä‚¢‚Ü‚¹‚ñB");
            return;
        }

        for (int i = 0; i < TapChanges.Length; i++)
        {
            if (TapChanges[i].Index != AnswerIndexes[i])
                return;
        }

        _IsOpen = true;
        foreach (var TapChange in TapChanges)
        {
            TapChange.enabled = false;
            var collider = TapChange.gameObject.GetComponent<BoxCollider>();
            if (collider != null)
                collider.enabled = false;
        }
        Invoke(nameof(CameraMove), 0.5f);
    }


    private void CameraMove()
    {
        CameraManager.Instance.ChangeCameraPosition(OpenPositionName);
        OpenCollider.SetActive(true);
    }
}
