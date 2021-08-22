using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerVoice : MonoBehaviour
{

    [SerializeField] AudioClip whatHappened;
    [SerializeField] AudioClip goodLandingArea;

    private AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = whatHappened;
        audioSource.Play();

    }

    
    void OnFindClearArea()
    {
        print(name + " OnFIndClearArea");
        audioSource.clip = goodLandingArea;
        audioSource.Play();

        Invoke("CallHeli", goodLandingArea.length + 1f);
    }

    void CallHeli()
    {
        SendMessageUpwards("OnMakeInitialHeliCall");
    }
}
