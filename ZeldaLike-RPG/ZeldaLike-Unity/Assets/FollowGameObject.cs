/* Author : Raphaël Marczak - 2018, for Label[i]
 * 
 * This work is licensed under the CC0 License. 
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowGameObject : MonoBehaviour {
    public GameObject m_objectToFollow;
	
	// At each frame, the camera position is set to the "objetToFollow" x and y coordinates
    // (z remains the one of the camera, to respect the depth)
	void Update () {
        this.transform.position = new Vector3(m_objectToFollow.transform.position.x,
                                              m_objectToFollow.transform.position.y,
                                              this.transform.position.z);
	}
}
