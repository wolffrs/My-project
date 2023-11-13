using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseManager : MonoBehaviour
{
    public bool phaseOneActive;
    public bool phaseInBetween;
    public bool phaseTwoActive;

    void Start()
    {
        phaseOneActive = true;
        phaseTwoActive = false;
        phaseInBetween = false;
    }

}
