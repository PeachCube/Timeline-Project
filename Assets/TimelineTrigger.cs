using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class NewBehaviourScript : MonoBehaviour
{
    public PlayableDirector timeline;
    private void OnTriggerEnter(Collider other)
    {
        timeline.Play();//Plays the timeline when the player enters the trigger volume
        gameObject.SetActive(false);//detroys the gameObject so the player can only activate it once.
    }
}
