using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HornSounds : MonoBehaviour
{
    private AudioSource hornsound;

    // �{�^����ݒ�ł���悤�ɂ���
    public Button button1;
    public Button button2;
    public Button button3;

    void Start()
    {
        hornsound = GetComponent<AudioSource>();

        // �e�{�^���ɃN���b�N�C�x���g��ݒ�
        button1.onClick.AddListener(PlayHornSound);
        button2.onClick.AddListener(PlayHornSound);
        button3.onClick.AddListener(PlayHornSound);
    }

    void PlayHornSound()
    {
        hornsound.PlayOneShot(hornsound.clip);
    }
}
