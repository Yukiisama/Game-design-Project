﻿/* Author : Raphaël Marczak - 2018, for Label[i]
 * 
 * This work is licensed under the CC0 License. 
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour {
    public List<DialogPage> m_dialogWithPlayer;

    public List<DialogPage> GetDialog()
    {
        return m_dialogWithPlayer;
    }
}
