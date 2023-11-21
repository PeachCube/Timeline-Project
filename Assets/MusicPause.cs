using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class MusicPause : MonoBehaviour
{
    public PlayableDirector timeline;
    private void OnTriggerEnter(Collider other)
    {
        timeline.Pause();
    }
    private void OnTriggerExit(Collider other)
    {
        timeline.Resume();
    }
}
