using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScript : DefaultTrackableEventHandler
{
    // Start is called before the first frame update
    public Rigidbody player;

    override protected void OnTrackingLost(){
        player.useGravity = false;
    }

    override protected void OnTrackingFound(){
        player.useGravity = true;
    }
}
