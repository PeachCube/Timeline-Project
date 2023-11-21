using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PauseTrigger : MonoBehaviour
{
    public PlayableDirector timeline;
    private void OnTriggerEnter(Collider other)
    {
        timeline.Play();//Plays the timeline when the player enters the trigger volume
    }
    private void OnTriggerExit(Collider other)
    {
        timeline.Pause();//Pauses the timeline when the player leaves the trigger
    }
}
